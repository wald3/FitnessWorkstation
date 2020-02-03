using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace DbFitness.Configurations
{
    class EquipmentInfoConfig : EntityTypeConfiguration<EquipmentInfo>
    {
        public EquipmentInfoConfig()
        {
            this.HasMany(se => se.SportEquipments)
                .WithMany(ei => ei.EquipmentInfos);

            this.ToTable("sport_equipment_infos");
            this.Property(c => c.Id).HasColumnName("sport_equipment_info_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.UseRules).HasColumnName("sport_equipment_info_usage_rules").IsRequired();
            this.Property(c => c.Purpose).HasColumnName("sport_equipment_info_purpose").IsRequired();
        }
    }
}
