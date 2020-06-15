using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewfun.Models;

namespace viewfun.Controllers {
    public class HomeController : Controller {
        [HttpGet ("")]
        public ViewResult Index () 
        {
            string[] testString = new string[] {"hey","what's","up?"};
            string[] newString = new string[] {"Hello","my","friend"};


            User aUser = new User(){
                Words = testString
            };

            User newUser = new User(){
                Words = newString
            };

            List<User> viewModel = new List<User> ()
            {
                aUser,newUser

            };
            return View(viewModel);

        }

        [HttpGet("user")]
        public ViewResult User()
        {
            return View();
        }

        [HttpGet("users")]
        public ViewResult Users()
        {
            User newUser = new User () 
            {
                FirstName = "Sally",
                LastName = "Sanderson"
            };

            User someUser = new User () 
            {
                FirstName = "Terrence",
                LastName = "Williams"
            };

            List<User> viewModel = new List<User> () 
            {
                newUser,someUser
            };
            return View (viewModel);
            // return View();
        }

        [HttpGet("numbers")]
        public ViewResult Numbers()
        {
            int[] numbers = new int[]{1,2,3,4};
            return View(numbers);
        }

        public IActionResult Names () {
            string[] names = new string[] {
                "Sally",
                "Billy",
                "Joey",
                "Moose"
            };
            return View (names);
        }

        public IActionResult Privacy () {
            return View ();
        }

        // [HttpGet ("{res}")]
        // public IActionResult Director (string res) {
        //     if (res == "") {
        //         return RedirectToAction ("Index");
        //     }
        //     return View ();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}