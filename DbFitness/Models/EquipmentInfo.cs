using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbFitness.Models
{
    public class EquipmentInfo
    {
        [Key]
        public int Id { get; set; }
        public string EquipmentProducer { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentUseRules { get; set; }
        public string EquipmentPurpose { get; set; }

        public virtual SportEquipment Equipment { get; set; }
    }
}