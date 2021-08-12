using System.Collections.Generic;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Mvc.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Service> _services = new List<Service>
        {
            new Service(0,"سرویس مورد نظر را انتخاب بفرمایید."),
            new Service(1,"برنزی"),
            new Service(2,"نقره ای"), 
            new Service(3,"طلایی"),
            new Service(4,"نیترو"),

        };

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services,"Id","Name","0")
            };
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
            modelContact.Services= new SelectList(_services, "Id", "Name", "0");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد. دوباره تلاش کنید";
                return View(modelContact);
            }

            ModelState.Clear();
             modelContact = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name", "0")
            };

            ViewBag.success = "پیام شما با موفقیت ارسال شد. ممنون از نظرات شما";
            
            return View(modelContact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
