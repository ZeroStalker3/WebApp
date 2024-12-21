using WebApp.Controllers;
using WebApp.Models;

namespace WebApp.TableControllers
{
    public class TypeLackController : GenericController<TypeLack>
    {
        public TypeLackController() : base("http://localhost:5000/api/TypeLack") { }
    }
}
