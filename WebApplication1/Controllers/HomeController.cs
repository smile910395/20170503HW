using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        Random gen = new Random(Guid.NewGuid().GetHashCode());
        
        public ActionResult Index()
        {
            var item = new List<MyClass>();
            Random rnd = new Random();
            DateTime day;
           
            for (var i = 1; i <= 200; i++)
            {
                //類別
                var num = rnd.Next(0,2);
                string type = "";
                if (num == 1) { type = "支出"; } else { type = "收入"; }
                //金額
                var money = rnd.Next(100,5000);
                //日期
               
                DateTime start = new DateTime(2010, 1, 1);
                int range = (DateTime.Today - start).Days;
                day = start.AddDays(rnd.Next(range));

                item.Add(new MyClass
                {
                    ID = i,
                    類別 = type,
                    日期 = day,
                    金額 = money
                });
                
            }
            return View(item);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
           

    }
}