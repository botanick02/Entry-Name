using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Entry_Name.Models;
using Entry_Name.Infrastructure;

namespace Entry_Name.Controllers
{
    [ControllerDeletePostfix("Danyil")]
    public class HomeControllerDanyil : Controller
    {

        public ViewResult Index()
        {

            return View();
        }

        [HttpPost]
        public ViewResult HelloName(PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                return View("HelloName", person);
            }
            return View("Index");
        }
    }
}
