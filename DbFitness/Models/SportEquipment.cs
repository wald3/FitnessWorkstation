using System;
using System.ComponentModel.DataAnnotations;

namespace DbFitness.Models
{
    public class SportEquipment
    {
        [Key]
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public int ClubId { get; set; }
        public Club Club { get; set; }
    }
}
