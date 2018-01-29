using AvaliacaoInfnet.Domain.Mailer;
using System.Web.Http;

namespace AvaliacaoInfnet.Web.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        [HttpGet, Route("emailTest")]
        public IHttpActionResult SendTestMail()
        {
            var mail = new Mailer();
            mail.EmailTest();
            return Ok();
        }
    }
}