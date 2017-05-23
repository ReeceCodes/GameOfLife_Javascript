using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace GameOfLife_Javascript.Controllers
{
    public class LifeController : SurfaceController
    {
        [ChildActionOnly]
        public ActionResult GetLife()
        {
            return PartialView("LifeView");
        }
    }
}