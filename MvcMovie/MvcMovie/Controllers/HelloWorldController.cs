﻿using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name , int numTimes　= 1)
        {
            ViewData["Message"] = $"こんにちは！{name}さん";
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
