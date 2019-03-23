using System.ComponentModel.DataAnnotations;

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
        public SportEquipment Equipment { get; set; }
    }
}