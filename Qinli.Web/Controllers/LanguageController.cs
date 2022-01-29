using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Qinli.Web.Controllers
{
    [Route("Language")]
    public class LanguageController : Controller
    {
        [Route("Change")]
        public IActionResult Change(string cultrue)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cultrue)),
                new Microsoft.AspNetCore.Http.CookieOptions
                {
                    Expires = System.DateTimeOffset.Now.AddDays(1)
                }
                );
            return RedirectToAction("Index","Home");
        }
    }
}
