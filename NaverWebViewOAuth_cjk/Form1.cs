using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Web;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;

namespace NaverWebViewOAuth
{
    public partial class Form1 : Form
    {
        private readonly string _clientID;
        private readonly string _clientSecret;
        private readonly string _redirectUri;
        private readonly string _authorizationUri;
        private readonly Random _random;

        public Form1()
        {
            _clientID = "706034885ad18c182c84048775b9ec43";
            _clientSecret = "CnZTE6s6wRCNxxZzjn4dW8lpamWYM3xw";
            _redirectUri = "https://lic.erpdom.com/UNIERPSmartDeploy";
            _authorizationUri = "https://kauth.kakao.com/oauth/authorize";
            _random = new Random();

            InitializeComponent();
            InitializeEvent();
        }

        private Dictionary<string, string> CreateAuthorizationArguments()
        {
            return new Dictionary<string, string>
            {
                { "response_type", "code" },
                { "client_id", _clientID },
                { "scope", "openid" },
                { "redirect_uri", HttpUtility.UrlEncode(_redirectUri) },
                { "state", CreateRandomText(10) },
                { "nonce", CreateRandomText(10) }
            };
        }

        private string CreateRandomText(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
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

        private string CreateAuthorizationAddress() 
        {
            var arguments = CreateAuthorizationArguments();
            var pairs = arguments.Select(pair => $"{pair.Key}={pair.Value}").ToArray();

            return $"{_authorizationUri}?{string.Join("&", pairs)}";
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

                        LoadOpenAuthToken(nvc["code"]);
                    }
                }
                /*
                if ()

                eventArgs.Cancel = true;
                */
            };

            webView2.CoreWebView2.Navigate(CreateAuthorizationAddress()); //접속해라
        }

        private void LoadOpenAuthToken(string codeForToken) //토큰 관리
        {
            MessageBox.Show(@"토큰 불러오기 준비!");
            
            var arguments = new Dictionary<string, string>()
            {
                { "grant_type", "authorization_code" },
                { "client_id", _clientID },
                { "redirect_uri", HttpUtility.UrlEncode(_redirectUri) },
                { "code", codeForToken },
                { "client_secret", _clientSecret }
            };

            var pairs = arguments.Select(pair => $"{pair.Key}={pair.Value}");

            try
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                    var result = client.UploadString("https://kauth.kakao.com/oauth/token", string.Join("&", pairs));
                    
                    MessageBox.Show(@"성공");
                    
                    var resultDic = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, object>>(result);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"오류!");
                Console.WriteLine(ex);
            }
        }
    }
}