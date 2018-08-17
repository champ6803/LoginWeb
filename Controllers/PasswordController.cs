using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoginWeb.Controllers
{
    public class PasswordController : Controller
    {
        public IActionResult Password()
        {
            return View();
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}