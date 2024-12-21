using WebApp.Controllers;
using WebApp.Models;

namespace WebApp.TableControllers
{
    public class EventEmployeeController : GenericController<EventEmployee>
    {
        public EventEmployeeController() : base("http://localhost:5000/api/EventEmployee") { }
    }
}
