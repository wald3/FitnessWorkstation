namespace DbFitness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAbonement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_abonements",
                c => new
                    {
                        cln_abonement_clientid = c.Int(nullable: false, identity: true),
                        cln_abonement_purchasedate = c.DateTime(nullable: false),
                        cln_abonement_price = c.Int(nullable: false),
                        cln_abonement_status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.cln_abonement_clientid)
                .ForeignKey("dbo.AbonementTypes", t => t.cln_abonement_clientid)
                .Index(t => t.cln_abonement_clientid);
            
            CreateTable(
                "dbo.AbonementTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Bio_Id = c.Int(),
                        ResortClub_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PersonInfoes", t => t.Bio_Id)
                .ForeignKey("dbo.Clubs", t => t.ResortClub_Id)
                .ForeignKey("dbo.tbl_abonements", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Bio_Id)
                .Index(t => t.ResortClub_Id);
            
            CreateTable(
                "dbo.PersonInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FisrtName = c.String(),
                        SecondName = c.String(),
                        Age = c.Int(nullable: false),
                        Adress_Id = c.Int(),
                        Phone_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresses", t => t.Adress_Id)
                .ForeignKey("dbo.Phones", t => t.Phone_Id)
                .Index(t => t.Adress_Id)
                .Index(t => t.Phone_Id);
            
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        BuildingNumber = c.Int(nullable: false),
                        Housing = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneOperator = c.String(),
                        CountryCode = c.Int(nullable: false),
                        PhoneCode = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PriceForOneVisit = c.Int(nullable: false),
                        Adress_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresses", t => t.Adress_Id)
                .Index(t => t.Adress_Id);
            
            CreateTable(
                "dbo.SportEquipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchaseDate = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Club_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubs", t => t.Club_Id)
                .Index(t => t.Club_Id);
            
            CreateTable(
                "dbo.Empolyees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnrollmentDate = c.DateTime(nullable: false),
                        LastPayoutDate = c.DateTime(nullable: false),
                        LastVacationDate = c.DateTime(nullable: false),
                        Bio_Id = c.Int(),
                        Position_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PersonInfoes", t => t.Bio_Id)
                .ForeignKey("dbo.Positions", t => t.Position_Id)
                .Index(t => t.Bio_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentPosition = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EquipmentInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EquipmentProducer = c.String(),
                        EquipmentName = c.String(),
                        EquipmentUseRules = c.String(),
                        EquipmentPurpose = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empolyees", "Position_Id", "dbo.Positions");
            DropForeignKey("dbo.Empolyees", "Bio_Id", "dbo.PersonInfoes");
            DropForeignKey("dbo.Clients", "Id", "dbo.tbl_abonements");
            DropForeignKey("dbo.SportEquipments", "Club_Id", "dbo.Clubs");
            DropForeignKey("dbo.Clients", "ResortClub_Id", "dbo.Clubs");
            DropForeignKey("dbo.Clubs", "Adress_Id", "dbo.Adresses");
            DropForeignKey("dbo.Clients", "Bio_Id", "dbo.PersonInfoes");
            DropForeignKey("dbo.PersonInfoes", "Phone_Id", "dbo.Phones");
            DropForeignKey("dbo.PersonInfoes", "Adress_Id", "dbo.Adresses");
            DropForeignKey("dbo.tbl_abonements", "cln_abonement_clientid", "dbo.AbonementTypes");
            DropIndex("dbo.Empolyees", new[] { "Position_Id" });
            DropIndex("dbo.Empolyees", new[] { "Bio_Id" });
            DropIndex("dbo.SportEquipments", new[] { "Club_Id" });
            DropIndex("dbo.Clubs", new[] { "Adress_Id" });
            DropIndex("dbo.PersonInfoes", new[] { "Phone_Id" });
            DropIndex("dbo.PersonInfoes", new[] { "Adress_Id" });
            DropIndex("dbo.Clients", new[] { "ResortClub_Id" });
            DropIndex("dbo.Clients", new[] { "Bio_Id" });
            DropIndex("dbo.Clients", new[] { "Id" });
            DropIndex("dbo.tbl_abonements", new[] { "cln_abonement_clientid" });
            DropTable("dbo.EquipmentInfoes");
            DropTable("dbo.Positions");
            DropTable("dbo.Empolyees");
            DropTable("dbo.SportEquipments");
            DropTable("dbo.Clubs");
            DropTable("dbo.Phones");
            DropTable("dbo.Adresses");
            DropTable("dbo.PersonInfoes");
            DropTable("dbo.Clients");
            DropTable("dbo.AbonementTypes");
            DropTable("dbo.tbl_abonements");
        }
    }
}
