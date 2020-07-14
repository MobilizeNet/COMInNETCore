using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            var myMail = new CDO.Message();
            myMail.Subject = "Sending email with CDO";
            myMail.From = "mauricio.rojas@mobilize.net";
            myMail.To = "orellabac@gmail.com";
            myMail.HTMLBody = "<h1>This is a message.</h1>";

            myMail.Configuration.Fields["http://schemas.microsoft.com/cdo/configuration/sendusing"].Value = 2;
            myMail.Configuration.Fields["http://schemas.microsoft.com/cdo/configuration/smtpserver"].Value = "localhost";
            myMail.Configuration.Fields["http://schemas.microsoft.com/cdo/configuration/smtpserverport"].Value = 25;
            myMail.Configuration.Fields.Update();
            myMail.Send();
            myMail = null;
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
