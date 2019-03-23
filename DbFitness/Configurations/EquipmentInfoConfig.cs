using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class EquipmentInfoConfig : EntityTypeConfiguration<EquipmentInfo>
    {
        public EquipmentInfoConfig()
        {
            this.ToTable("tbl_equipmentInfos").HasKey(e => e.Id);
            this.Property(e => e.Id).HasColumnName("cln_equipmentInfo_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.EquipmentName).HasColumnName("cln_equipmentInfo_name");
            this.Property(e => e.EquipmentProducer).HasColumnName("cln_equipmentInfo_producer");
            this.Property(e => e.EquipmentPurpose).HasColumnName("cln_equipmentInfo_purpose");
            this.Property(e => e.EquipmentUseRules).HasColumnName("cln_equipmentInfo_rules");
        }
    }
}
