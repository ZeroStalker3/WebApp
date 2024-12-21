using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Controllers;
using WebApp.Models;

namespace WebApp.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : GenericController<Calendar>
    {
        public CalendarController() : base("http://localhost:5000/api/Calendar") { }
    }
}
