using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Controllers;
using WebApp.Models;

namespace WebApi.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : GenericController<Post>
    {
        public PostController(): base("http://localhost:5000/api/Post") { }
    }
}
