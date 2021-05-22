using EdliyyeTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Helpers;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nancy.Json;

namespace EdliyyeTask.Controllers
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

        public async Task<IActionResult> GetUserData()
        {

            var jsonPosts =  (new WebClient()).DownloadString("https://jsonplaceholder.typicode.com/posts");


            JavaScriptSerializer ser = new JavaScriptSerializer();
            var userPosts = ser.Deserialize<List<UsersPost>>(jsonPosts);





            return View(userPosts);
        }

        public IActionResult GetDatabyId(int id)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var jsonComments = (new WebClient()).DownloadString("https://jsonplaceholder.typicode.com/comments/"+id);
            var userComments = ser.Deserialize<List<UsersComments>>(jsonComments);
            return Json(userComments);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
