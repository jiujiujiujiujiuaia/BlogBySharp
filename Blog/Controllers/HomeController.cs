using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class HomeController : Controller
    {
        [Route("api/ping")]
        public IActionResult Index()
        {
            return Ok("Do a little things everyday!!");
        }
    }
}
