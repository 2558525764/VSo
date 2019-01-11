using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.ViewModel;
using ContosoUniversity.Common;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            var date=WeatherHelper.GetWeatcherByCityName("柳州");
            return View(date);
        }
        public JsonResult Getweatcher(string city)
        {
            var date = WeatherHelper.GetWeatcherByCityName(city);
            var json = Json(date);
            return json;
        }

        public ActionResult About()
        {
            IQueryable<EnrollmentDateGroup> data = from student in db.Students
                      group student by student.EnrollmentDate into dateGroup
                      select new EnrollmentDateGroup()
                     {
                       EnrollmentDate = dateGroup.Key,
                       StudentCount = dateGroup.Count()
                      };
            return View(data.ToList());
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}