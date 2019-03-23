using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class SportEquipment
    {
        [Key]
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
    }
}
