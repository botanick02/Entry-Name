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

        public string HelloName(string name)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}");
        }
    }
}
