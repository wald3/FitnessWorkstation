using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class SportEquipment : Table
    {        
        public string Producer { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime InstallationDate { get; set; }

        public int? ClubId { get; set; }
        public virtual Club Club { get; set; }

        public ICollection<EquipmentInfo> EquipmentInfos { get; set; }
    }
}
