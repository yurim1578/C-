using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace WebApplication3
{
    public class AssignOAuth2SecurityRequirements : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            // 인증이 필요한 API에 대해 인증 스키마 추가
            if (operation.security == null)
            {
                operation.security = new List<IDictionary<string, IEnumerable<string>>>();
            }

            var oAuthRequirements = new Dictionary<string, IEnumerable<string>>
            {
                { "oauth2", new List<string> { "openid" } }
            };

            operation.security.Add(oAuthRequirements);
        }
    }
}