using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Controllers;
using WebApp.Models;

namespace WebApp.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinetConroller : GenericController<Cabinet>
    {
        public CabinetConroller() : base("http://localhost:5181/api/Cabinet") { }
    }
}
