using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace FitnessAWP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new DbFitness.Context.DbFitnessСontext())
            {
                foreach (var club in db.Clubs.Include(c => c.Persons.Select(p=>p.PersonInfo)))
                {
                    var persons = club.Persons.ToList();

                }
                


            }

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
