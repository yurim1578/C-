using IdentityModel.Client;
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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GoogleOIDCTest
{
    public partial class Form1 : Form
    {
        private readonly string _clientID;
        private readonly string _clientSecret;
        private readonly string _redirectUri;
        private readonly string _authorizationUri;

        public Form1()
        {
            _clientID = "1044737486771-2u8mr7t1s2o399btrv7ucdp4m9qfvc9j.apps.googleusercontent.com";
            _clientSecret = "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";
            _redirectUri = "https://mail.bizentro.com/convergenceHome.do";
            _authorizationUri = "https://accounts.google.com/o/oauth2/v2/auth";
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
            var requestToken = new AuthorizationCodeTokenRequest
            {
                Address = "https://oauth2.googleapis.com/token", // Google Token Endpoint
                ClientId = _clientID,
                ClientSecret = _clientSecret,
                RedirectUri = _redirectUri,
                GrantType = "authorization_code",
                Code = nvc["code"]
            };

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.RequestAuthorizationCodeTokenAsync(requestToken);

                    if (response.IsError)
                    {
                        Debug.WriteLine($"Token request error: {response.Error}");
                    }
                    else
                    {
                        
                        Debug.WriteLine($"Access Token: {response.AccessToken}");
                        Debug.WriteLine($"ID Token: {response.IdentityToken}");

                        // 필요한 작업을 수행합니다.
                        ProcessTokenResponse(response);
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
                { "scope", "openid" },
                { "redirect_uri", HttpUtility.UrlEncode(_redirectUri)}
            };
        }
    }
}
