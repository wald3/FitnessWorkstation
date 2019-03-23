using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DbFitness.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public int PriceForOneVisit { get; set; }
        public virtual Adress Adress { get; set; }

        public virtual ICollection<SportEquipment> Equipments { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
