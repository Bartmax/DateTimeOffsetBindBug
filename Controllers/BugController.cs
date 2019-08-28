using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class BugController : Controller
    {
        public ActionResult Index([FromHeader]DateTimeOffset dt)
        {
            return Ok(dt);
        }
    }
}