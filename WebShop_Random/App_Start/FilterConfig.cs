﻿using System.Web;
using System.Web.Mvc;

namespace WebShop_Random
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
