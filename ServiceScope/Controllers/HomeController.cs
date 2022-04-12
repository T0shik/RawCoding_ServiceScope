using Microsoft.AspNetCore.Mvc;
using ServiceScope.Services;

namespace ServiceScope.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService _singleton;
        private readonly IScopedService _scoped;
        private readonly ITransientService _transient;

        public HomeController(
            ISingletonService singleton,
            IScopedService scoped,
            ITransientService transient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
        }

        [Route("/")]
        public IActionResult Singleton()
        {
            return View("Singleton", _singleton.GetGuid());
        }

        public IActionResult Scoped()
        {
            return View("Scoped", _scoped.GetGuid());
        }

        public IActionResult Transient()
        {
            return View("Transient", _transient.GetGuid());
        }
    }
}
