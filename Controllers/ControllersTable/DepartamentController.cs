using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Controllers;
using WebApp.Models;

namespace WebApp.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentController : GenericController<Departament>
    {
        public DepartamentController() : base("http://localhost:5181/api/Departament") { }
    }
}
