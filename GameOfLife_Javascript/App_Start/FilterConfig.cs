﻿using System.Web;
using System.Web.Mvc;

namespace GameOfLife_Javascript
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
