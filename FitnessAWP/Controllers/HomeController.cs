using DbFitness.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace FitnessAWP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            
            using (var db = new DbFitness.Context.DbFitnessСontext())
            {
                var clubs = db.Clubs.Include(c=> c.Clients.Select(cl =>  cl.Abonement)).Include(c => c.Clients.Select(cl => cl.UserInfo)).Include(c => c.Employees).Include(c=> c.Address);
                try
                {
                    foreach (var club in clubs)
                    {
                        System.Diagnostics.Debug.WriteLine($"Club Id: {club.Id}, " +
                                                           $"Address: {club.Address.StreetName}, {club.Address.Housing}");
                        var clients = club.Clients;
                        foreach (var c in clients)
                        {
                            
                            System.Diagnostics.Debug.WriteLine($"Id: {c.Id}, " +
                                                               $"Name: {c.UserInfo.FirstName}, " +
                                                               $"Surname: {c.UserInfo.SecondName}, " +
                                                               $"Address: [{c.UserInfo.Address.Country}, {c.UserInfo.Address.StreetName}]");
                            if (c.Abonement != null)
                            {
                                var isTypeEqual = c.Abonement.Type == AbonementType.MonthOne;
                                System.Diagnostics.Debug.WriteLine($"Abon: [{c.Abonement.Type}: Price {c.Abonement.Price}]");
                            }
                        }
                    }
                }
                catch (System.Exception e)
                {
                    while (e.InnerException != null)
                    {
                        e = e.InnerException;
                        System.Diagnostics.Debug.WriteLine("INNER: " + e.Message + "\n\n");
                    }
                    throw;
                }

            }
            ViewBag.Title = "Home Page";
            return View();
        }
    }
}
