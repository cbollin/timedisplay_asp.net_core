using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controllers1.Controllers
{
    public class HelloController : Controller
    {
        // get method [HttpGet] is optional on GET routes, but all POST routes must have an [HttpPost]
        [HttpGet]
        [Route("/")] //A route of Route("template") will match the url localhost:5000/template.
        public IActionResult Index()
        {
            
            DateTime CurrentTime = DateTime.Now;
            @ViewBag.CurrentTime = DateTime.Now;

            return View(); //tell our controller to actually serve the view.
            //OR
            // return View("Index");
         //Both of these returns will render the same view
        }
        
        // [HttpGet]
        // [Route("template/{Name}")]
        // public IActionResult Method(string Name)
        // {
        //  return("hello", Name);
        // }

        // A POST method
        // [HttpPost]
        // [Route("")]
        // public IActionResult Other()
        // {
        //     return View();
        // }
    }
}
