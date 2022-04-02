using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Entry_Name.Models;

namespace Entry_Name.Controllers
{
    public class EntryNameController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult HelloName(Person person)
        {
            return View("HelloName", person);
        }
    }
}
