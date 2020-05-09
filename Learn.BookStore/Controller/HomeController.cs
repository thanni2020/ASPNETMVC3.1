using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Learn.BookStore
{
    public class HomeController: Controller
    {
        public string Index()
        {
            return "Welcome to ASP.NET Core Class";
        }
    }
}
