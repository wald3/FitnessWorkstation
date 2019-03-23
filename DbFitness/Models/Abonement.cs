using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class Abonement
    {
        [Key]
        public int ClientId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }

        public virtual Client Client { get; set; }
        public virtual AbonementType AbonementType { get; set; }
    }
}
