using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    [Authorize]  // 이 컨트롤러의 모든 엔드포인트는 인증 필요
    [RoutePrefix("api/account")]
    public class ValuesController : ApiController
    {
        /*   // GET api/values
           public IEnumerable<string> Get()
           {
               return new string[] { "value1", "value2" };
           }

           // GET api/values/5
           public string Get(int id)
           {
               return "value";
           }*/







        [HttpGet]
        [AllowAnonymous]
        [Route("profile")]
        public IHttpActionResult GetProfile()
        {
            // 사용자 정보 가져오기
            var userName = User.Identity.Name;

            return Ok(new
            {
                UserName = userName,
                Message = "This is a protected API endpoint"
            });
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("api/naverlogin")]
        public IHttpActionResult PublicEndpoint()
        {
            return Ok(new string[] { "value1", "value2" });
        }
        /* // POST api/values
         public void Post([FromBody] string value)
         {

         }

         // PUT api/values/5
         public void Put(int id, [FromBody] string value)
         {
         }

         // DELETE api/values/5
         public void Delete(int id)
         {
         }*/

    }
}
