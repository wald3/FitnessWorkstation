using System;
using System.ComponentModel.DataAnnotations;

namespace DbFitness.Models
{
    public class Abonement
    {
        [Key]
        public int ClientId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public AbonementType AbonementType { get; set; }
    }
}
