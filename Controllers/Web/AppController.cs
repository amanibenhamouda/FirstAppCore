using FirstAppCore.Services;
using FirstAppCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAppCore.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;

        public AppController(IMailService mailService,IConfigurationRoot config)
        {
            _mailService = mailService;
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (model.Email.Contains("al.com"))
            {
                ModelState.AddModelError("Email","we don't support al domain");
            }
            if (ModelState.IsValid)
            {
                _mailService.SendMail(_config["MailSettings:ToAddress"], model.Email, "The world subject", model.Message);

                ModelState.Clear();
                ViewBag.UserMessage = "Message sent";
            }
            return View();
        }
    }
}
