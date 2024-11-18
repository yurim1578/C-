using IdentityModel.Client;
using IdentityModel.OidcClient;
using Infragistics.Win.UltraWinEditors;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace NaverOIDCTest
{
    public partial class Form1 : Form
    {
        private readonly string _clientID;
        private readonly string _clientSecret;
        private readonly string _redirectUri;
        private readonly string _authorizationUri;
        private readonly string state;

        public Form1()
        {
            _clientID = "hbLJPlbTyUOthnL9cyue";
            _clientSecret = "enQb06wY5E";
            _redirectUri = "https://mail.bizentro.com/convergenceHome.do";
            _authorizationUri = "https://auth.worksmobile.com/oauth2/v2.0/authorize";
            state = (new Random()).Next().ToString();
            InitializeComponent();

            InitializeEvent();
        }

        private void InitializeEvent()
        {
            webView21.CoreWebView2InitializationCompleted += (sender, args) =>
            {
                EventOnWebViewInitialized(webView21);
            };
            Shown += (sender, args) =>
            {
                webView21.EnsureCoreWebView2Async();
            };
        }

        private void EventOnWebViewInitialized(WebView2 webView2) // auth server 로그인창 요청
        {
            webView2.CoreWebView2.NavigationStarting += (sender, eventArgs) =>
            {
                Debug.WriteLine($"현재 접속 : {eventArgs.Uri}");
                var split = eventArgs.Uri.Split('?');

                if (split.Length > 1)
                {
                    var nvc = HttpUtility.ParseQueryString(split[1]);

                    foreach (var key in nvc.AllKeys)
                    {
                        Debug.WriteLine($"구성요소 : {key} / {nvc[key]}");
                    }

                    if (nvc.AllKeys.Contains("code"))
                    {
                        eventArgs.Cancel = true;

                        LoadToken(nvc);

                    }
                }
            };

            webView2.CoreWebView2.Navigate(CreateAuthorizationAddress()); //접속해라
        }

        private async void LoadToken(NameValueCollection nvc)
        {
            

            try
            {
                var client = new HttpClient();
                var values = new Dictionary<string, string>
{
    { "redirect_uri", _redirectUri},
    { "grant_type", "authorization_code" },
    { "client_id", _clientID },
    { "client_secret", _clientSecret },
    { "code", nvc["code"] }
};

                var content = new FormUrlEncodedContent(values);
                
                var response = await client.PostAsync("https://auth.worksmobile.com/oauth2/v2.0/token", content);

                var responseString = await response.Content.ReadAsStringAsync();

                var resultDic = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, object>>(responseString);

                if (resultDic.TryGetValue("id_token", out var value))
                {
                    var txtIdToken = value.ToString();
                    var handler = new JwtSecurityTokenHandler();
                    var token = (JwtSecurityToken)handler.ReadToken(txtIdToken);

                    foreach (var claim in token.Claims)
                    {
                        ultraTextEditor1.Text += $@"{claim.Type} : {claim.Value}";

                        if (!string.IsNullOrEmpty(ultraTextEditor1.Text))
                        {
                            ultraTextEditor1.Text += Environment.NewLine;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception: {ex.Message}");
            }
        }

        private void ProcessTokenResponse(TokenResponse response)
        {
            // Access Token
            string accessToken = response.AccessToken;
            Debug.WriteLine($"Access Token: {accessToken}");

            // ID Token (JWT)
            if (!string.IsNullOrEmpty(response.IdentityToken))
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(response.IdentityToken);

                Debug.WriteLine("ID Token Claims:");
                foreach (var claim in jwtToken.Claims)
                {
                    Debug.WriteLine($"  {claim.Type}: {claim.Value}");
                }
            }
        }


        private string CreateAuthorizationAddress()
        {
            var arguments = CreateAuthorizationArguments();
            var pairs = arguments.Select(pair => $"{pair.Key}={pair.Value}").ToArray();

            return $"{_authorizationUri}?{string.Join("&", pairs)}";
        }

        private Dictionary<string, string> CreateAuthorizationArguments()   //필수 요소들 보내기
        {

            return new Dictionary<string, string>
            {
                { "response_type", "code" },
                { "client_id", _clientID },
                { "redirect_uri", _redirectUri},
                {"scope","openid email profile" },
                { "state",state}
            };
        }
    }
}
