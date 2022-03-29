using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace Entry_Name.Controllers
{
    public class EntryHelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
