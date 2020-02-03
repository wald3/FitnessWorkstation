using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class SportEquipmentConfig : EntityTypeConfiguration<SportEquipment>
    {
        public SportEquipmentConfig()
        {
            this.HasMany(se => se.EquipmentInfos)
                .WithMany(ei => ei.SportEquipments);

            this.HasRequired<Club>(p => p.Club)
                .WithMany(c => c.SportEquipments)
                .HasForeignKey<int?>(p => p.ClubId)
                .WillCascadeOnDelete(false);

            this.ToTable("sport_equipments");
            this.Property(c => c.Id).HasColumnName("sport_equipment_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Producer).HasColumnName("sport_equipment_producer").IsRequired();
            this.Property(c => c.Name).HasColumnName("sport_equipment_naming").IsRequired();
            this.Property(c => c.Amount).HasColumnName("sport_equipment_amount").IsOptional();
            this.Property(c => c.InstallationDate).HasColumnName("sport_equipment_installation_date_utc").IsRequired();
            this.Property(c => c.ClubId).HasColumnName("sport_equipment_clud_id").IsRequired();
        }
    }
}
