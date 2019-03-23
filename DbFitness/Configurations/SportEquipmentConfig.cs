﻿using DbFitness.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFitness.Configurations
{
    class SportEquipmentConfig : EntityTypeConfiguration<SportEquipment>
    {
        public SportEquipmentConfig()
        {
            this.ToTable("tbl_sportEquipments").HasKey(se => se.Id);
            this.Property(se => se.Id).HasColumnName("cln_sportEquipment_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(se => se.PurchaseDate).HasColumnName("cln_sportEquipment_purchaseDate");
            this.Property(se => se.Amount).HasColumnName("cln_sportEquipment_amount");
            this.Property(se => se.Price).HasColumnName("cln_sportEquipment_price");
        }
    }
}
