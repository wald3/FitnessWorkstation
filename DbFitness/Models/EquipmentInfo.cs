using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class EquipmentInfo : Table
    {
        public string UseRules { get; set; }
        public string Purpose { get; set; }
        public ICollection<SportEquipment> SportEquipments { get; set; }
    }
}
