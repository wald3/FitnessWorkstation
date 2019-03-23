using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class PositionConfig : EntityTypeConfiguration<Position>
    {
        public PositionConfig()
        {
            this.ToTable("tbl_positions").HasKey(p => p.Id);
            this.Property(p => p.Id).HasColumnName("cln_position_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.CurrentPosition).HasColumnName("cln_position_currentPosition");
        }
    }
}
