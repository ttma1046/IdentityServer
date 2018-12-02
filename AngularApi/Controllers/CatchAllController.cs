using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularApi.Controllers
{
    public class CatchAllController: ControllerBase
    {
        public IActionResult Index()
        {
            return File("~/index.html", "text/html");
        }
        
    }
}

