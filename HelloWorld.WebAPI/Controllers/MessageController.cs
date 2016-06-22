
using System.Web.Http;
using HelloWorld.Interfaces;
using HelloWorld.WebAPI.ServiceLayer;

namespace HelloWorld.WebAPI.Controllers
{
    [RoutePrefix("api/Message")]
    public class MessageController : ApiController
    {
        private readonly MessageService service = new MessageService();

        [HttpGet]
        public IMessage Get()
        {
            return service.GetMessage();
        }
    }
}