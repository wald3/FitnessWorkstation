using DbFitness.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DbFitness.Configurations
{
    class ClubConfig : EntityTypeConfiguration<Club>
    {
        public ClubConfig()
        {
            this.ToTable("tbl_clubs").HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("cln_club_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.PriceForOneVisit).HasColumnName("cln_club_priceForOneVisit");
        }
    }
}
