using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_ClaimSystem__CMCS_.Controllers
{
    public class ClaimsController : Controller
    {
        public IActionResult Submit()
        {
            return View();
        }

        public IActionResult Approve()
        {
            return View();
        }
    }
}