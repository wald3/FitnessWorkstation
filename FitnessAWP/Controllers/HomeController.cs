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
                try
                {
                    foreach (var club in db.Clubs)
                    {
                        System.Diagnostics.Debug.WriteLine($"Club Id: {club.Id}, " +
                                                           $"Address: {club.Address.StreetName}, {club.Address.Housing}");
                        var clients = club.Clients.ToList();
                        foreach (var c in clients)
                        {
                            
                            System.Diagnostics.Debug.WriteLine($"Id: {c.Id}, " +
                                                               $"Name: {c.UserInfo.FirstName}, " +
                                                               $"Surname: {c.UserInfo.SecondName}, " +
                                                               $"Address: [{c.UserInfo.Address.Country}, {c.UserInfo.Address.StreetName}], " +
                                                               $"Abon: [{c.Abonement.Type} - {c.Abonement.Price}]");
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
