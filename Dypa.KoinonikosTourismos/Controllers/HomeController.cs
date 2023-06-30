using Dypa.KoinonikosTourismos.Types;
using Microsoft.AspNetCore.Mvc;

namespace Dypa.KoinonikosTourismos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DypaDbContext _db;

        public HomeController(
            ILogger<HomeController> logger,
            DypaDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results([FromForm] string formVatNumber, string formSocialSecurityNumber)
        {
            // get the last 4 digits of vat and social security number.
            var vatNumber4digits = formVatNumber.Substring(formVatNumber.Length - 4);
            var socialSecurityNumber4digits = formSocialSecurityNumber.Substring(formSocialSecurityNumber.Length - 4);

            // search for user by their provided data.
            Selected? selected = null;
            RunnerUp? runnerUp = null;
            Rejected? rejected = null;

            selected = _db.Selected.SingleOrDefault(s => s.VatNumber!.EndsWith(vatNumber4digits) && s.SocialSecurityNumberAlt!.EndsWith(socialSecurityNumber4digits));

            if (selected == null)
            {
                runnerUp = GetSingleOrDefaultFor<RunnerUp>(vatNumber4digits, socialSecurityNumber4digits);
                if (runnerUp == null)
                {
                    rejected = GetSingleOrDefaultFor<Rejected>(vatNumber4digits, socialSecurityNumber4digits);
                }
            }
            
            // provide results to view.
            ViewData[Consts.ViewBag.Selected] = selected;
            ViewData[Consts.ViewBag.RunnerUp] = runnerUp;
            ViewData[Consts.ViewBag.Rejected] = rejected;

            return View();
        }

        private T? GetSingleOrDefaultFor<T>(string vatNumber, string socialSecurityNumber) where T : BasicInfoEntity
        {
            return _db.Set<T>()?.SingleOrDefault(s => s.VatNumber!.EndsWith(vatNumber) && s.SocialSecurityNumber!.EndsWith(socialSecurityNumber));
        }
    }
}