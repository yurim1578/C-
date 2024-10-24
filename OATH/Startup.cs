using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Jwt;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;

[assembly: OwinStartup(typeof(WebApplication3.Startup))]
namespace WebApplication3
{
 
    public class Startup
    {
        
        public void Configuration(IAppBuilder app)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            var issuer = "https://your-auth-server.com";
            var audience = "your-api";
            var secret = "your-client-secret";

            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
            {
                AuthenticationMode = AuthenticationMode.Active,
                TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = issuer,
                    ValidAudience = audience,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secret))
                }
            });
        }
    }
}