using WebApp.Controllers;
using WebApp.Models;

namespace WebApp.TableControllers
{
    public class WorkingCalendarController :  GenericController<WorkingCalendar>
    {
        public WorkingCalendarController() : base("http://localhost:5000/api/WorkingCalendar") { }
    }
}
