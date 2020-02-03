using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Abonement : Table
    {
        private readonly int PriceForOneVisit = 5;
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }
        public bool isActive { get; set; }
        public AbonementType Type { get; set; }
        public Abonement() { }
        public Abonement(AbonementType t)
        {
            Type = t;
            PurchaseDate = DateTime.UtcNow;
            Price = (int)t * PriceForOneVisit;
            isActive = true;
        }
    }
    public enum AbonementType
    {
        Year       = 364,
        MonthSix   = 364 / 2,
        MonthThree = 364 / 4,
        MonthOne   = 364 / 12,
        VisitNine  = 9,
        VisitThree = 3,
        VisitOne   = 1
    }
}
