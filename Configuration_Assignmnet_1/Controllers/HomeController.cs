using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Configuration_Assignmnet_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly SocialMediaLinksOptions _options;
        public HomeController(IOptions<SocialMediaLinksOptions> options)
        {
            _options = options.Value;
        }
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.SocialMediaLinks = _options;
            return View();
        }
    }
}
