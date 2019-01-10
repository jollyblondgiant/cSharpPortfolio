using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public IActionResult Index (){
            ViewBag.Example = "Welcome to Hell";
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects(){
            
            ViewBag.Projects = "<div class = 'item'><img src='~/img/myFace.jpg' alt = 'myFace'> <div class = 'itemText'><h3>Cool Thing!</h3><p>some text</p></div></div>";
            return View("Projects");
        }
        [HttpGet("contact")]
        public ViewResult Contact(){
            return View("Contact");
        }
    }
}