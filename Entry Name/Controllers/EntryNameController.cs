using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace Entry_Name.Controllers
{
    public class EntryNameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HelloName(string name)
        {
            ViewData["Name"] = name;
            return View();
        }
    }
}
