using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication3.App_Start
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {

                    c.SingleApiVersion("v1", "My API");
                    // OAuth2 및 OIDC 설정
                    c.OAuth2("oauth2")
                      .Description("OAuth2 with OpenID Connect")
                      .Flow("accessCode")  // Authorization Code Flow 사용
                      .AuthorizationUrl("https://mail.bizentro.com/home.do")//인증되면 콜백 되는 곳
                      .TokenUrl("https://your-auth-server.com/connect/token") //토큰 요청하는 곳
                      .Scopes(scopes =>
                      // Action<IDictionary<string, string>> 형태로 Scopes 설정
                      {
                          scopes.Add("openid", "OpenID Connect scope");
                          scopes.Add("description", "description asdf");
                      });

                    // 인증 요구 사항 추가
                    c.OperationFilter<AssignOAuth2SecurityRequirements>();
                    // API 버전별로 그룹화 설정 (예: v1, v2)
                    c.GroupActionsBy(api => api.ActionDescriptor.ControllerDescriptor.ControllerName);
                })
                .EnableSwaggerUi(c =>
                {
                    // Swagger UI에서 OAuth2 설정
                    c.EnableOAuth2Support(
                        clientId: "Ej3EnBja2hXJ8CFeItHR",
                        clientSecret: "eVnnn7b0tw",
                        realm: "",
                        appName: "Swagger UI",
                        scopeSeperator: " ",
                        additionalQueryStringParams: new Dictionary<string, string>()
                    );
                });
        }
    }
}