using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Доброго дня";
            return View();
        }

        [HttpGet]
        public ViewResult Form()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Form(FlowersResponse guest)
        {
            // Нужно отправить данные заказа

            // (ModelState.IsValid)
                return View("Thanks", guest);
           //else
                // Обнаружена ошибка проверки достоверности
              //return View();
            //return View("Thanks", guest);
        }


        // [HttpGet]
        public ViewResult Bouquets()
        {
            return View();
        }

    }
}