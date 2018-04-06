using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreUIVueJs.Models;
using Microsoft.AspNetCore.Hosting;

namespace AspNetCoreUIVueJs.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostenv;
        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostenv = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JavaScriptResult Scripts()
        {
            string webRootPath = _hostenv.WebRootPath;

            string result = System.IO.File.ReadAllText(webRootPath + "/JavaScript.js");
            result += System.IO.File.ReadAllText(webRootPath + "/JavaScript1.js");

            return new JavaScriptResult(result);
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

        public class JavaScriptResult : ContentResult
        {
            public JavaScriptResult(string script)
            {
                this.Content = script;
                this.ContentType = "application/javascript";
            }
        }
    }
}
