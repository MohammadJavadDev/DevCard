using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DevCard_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }
/*
        [HttpPost]
        public JsonResult Contact(IFormCollection form)
        {
            var name = form["name"];
            return Json(Ok());
        }*/
        [HttpPost]
        public IActionResult Contact(Contact modelContact)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد. دوباره تلاش کنید";
                return View(modelContact);
            }

            ViewBag.success = "پیام شما با موفقیت ارسال شد. ممنون از نظرات شما";
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
