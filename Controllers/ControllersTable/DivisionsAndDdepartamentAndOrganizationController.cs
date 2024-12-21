using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Controllers;
using WebApp.Models;

namespace WebApp.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionsAndDdepartamentAndOrganizationController : GenericController<DivisionsAndDdepartamentAndOrganization>
    {
        public DivisionsAndDdepartamentAndOrganizationController() : base("http://localhost:5000/api/DivisionsAndDdepartamentAndOrganization") { }
    }
}
