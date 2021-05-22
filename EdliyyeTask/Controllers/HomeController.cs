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
            JsonObjectsViewModel jsonObjectsView = new JsonObjectsViewModel();
            var jsonPosts = (new WebClient()).DownloadString("https://jsonplaceholder.typicode.com/posts");
            var jsonComments = (new WebClient()).DownloadString("https://jsonplaceholder.typicode.com/comments");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var userPosts = ser.Deserialize<List<UsersPost>>(jsonPosts);
            var userComments = ser.Deserialize<List<UsersComments>>(jsonComments);
            jsonObjectsView.userPosts = userPosts;
            jsonObjectsView.userComments = userComments;
      
            
                 
            return View(jsonObjectsView);
        }

        public IActionResult GetDatabyId(int userCommentPostId)
        {
            return View();
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
