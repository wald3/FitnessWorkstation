namespace DbFitness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConfigs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_abonements",
                c => new
                    {
                        cln_abonement_clientId = c.Int(nullable: false, identity: true),
                        cln_abonement_purchaseDate = c.DateTime(nullable: false),
                        cln_abonement_price = c.Int(nullable: false),
                        cln_abonement_status = c.Boolean(nullable: false),
                        AbonementType_AbonementId = c.Int(),
                    })
                .PrimaryKey(t => t.cln_abonement_clientId)
                .ForeignKey("dbo.tbl_abonementsTypes", t => t.AbonementType_AbonementId)
                .Index(t => t.AbonementType_AbonementId);
            
            CreateTable(
                "dbo.tbl_abonementsTypes",
                c => new
                    {
                        cln_abonementType_abonementId = c.Int(nullable: false, identity: true),
                        cln_abonementType_type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cln_abonementType_abonementId);
            
            CreateTable(
                "dbo.tbl_adress",
                c => new
                    {
                        cln_adress_id = c.Int(nullable: false, identity: true),
                        cln_adress_country = c.String(nullable: false, maxLength: 100),
                        cln_adress_city = c.String(nullable: false, maxLength: 100),
                        cln_adress_street = c.String(nullable: false, maxLength: 100),
                        cln_adress_buildingNumber = c.Int(nullable: false),
                        cln_adress_housing = c.String(),
                    })
                .PrimaryKey(t => t.cln_adress_id);
            
            CreateTable(
                "dbo.tbl_clients",
                c => new
                    {
                        cln_client_id = c.Int(nullable: false, identity: true),
                        cln_client_isActive = c.Boolean(nullable: false),
                        cln_client_clubId = c.Int(nullable: false),
                        Abonement_ClientId = c.Int(),
                        Bio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.cln_client_id)
                .ForeignKey("dbo.tbl_abonements", t => t.Abonement_ClientId)
                .ForeignKey("dbo.tbl_personeInfos", t => t.Bio_Id)
                .ForeignKey("dbo.tbl_clubs", t => t.cln_client_clubId, cascadeDelete: true)
                .Index(t => t.cln_client_clubId)
                .Index(t => t.Abonement_ClientId)
                .Index(t => t.Bio_Id);
            
            CreateTable(
                "dbo.tbl_personeInfos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cln_personInfo_firstName = c.String(),
                        cln_personInfo_secondName = c.String(),
                        cln_personInfo_age = c.Int(nullable: false),
                        Adress_Id = c.Int(),
                        Phone_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbl_adress", t => t.Adress_Id)
                .ForeignKey("dbo.tbl_phones", t => t.Phone_Id)
                .Index(t => t.Adress_Id)
                .Index(t => t.Phone_Id);
            
            CreateTable(
                "dbo.tbl_phones",
                c => new
                    {
                        cln_phone_id = c.Int(nullable: false, identity: true),
                        cln_phone_phoneOperator = c.String(maxLength: 50),
                        cln_phone_countryCode = c.Int(nullable: false),
                        cln_phone_phoneCode = c.Int(nullable: false),
                        cln_phone_phoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cln_phone_id);
            
            CreateTable(
                "dbo.tbl_clubs",
                c => new
                    {
                        cln_club_id = c.Int(nullable: false, identity: true),
                        cln_club_priceForOneVisit = c.Int(nullable: false),
                        Adress_Id = c.Int(),
                    })
                .PrimaryKey(t => t.cln_club_id)
                .ForeignKey("dbo.tbl_adress", t => t.Adress_Id)
                .Index(t => t.Adress_Id);
            
            CreateTable(
                "dbo.tbl_sportEquipments",
                c => new
                    {
                        cln_sportEquipment_id = c.Int(nullable: false, identity: true),
                        cln_sportEquipment_purchaseDate = c.DateTime(nullable: false),
                        cln_sportEquipment_amount = c.Int(nullable: false),
                        cln_sportEquipment_price = c.Int(nullable: false),
                        ClubId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cln_sportEquipment_id)
                .ForeignKey("dbo.tbl_clubs", t => t.ClubId, cascadeDelete: true)
                .Index(t => t.ClubId);
            
            CreateTable(
                "dbo.tbl_employees",
                c => new
                    {
                        cln_employee_id = c.Int(nullable: false, identity: true),
                        cln_employee_enrollmentDate = c.DateTime(nullable: false),
                        cln_employee_lastPayOutDate = c.DateTime(nullable: false),
                        cln_employee_lastVacationDate = c.DateTime(nullable: false),
                        Bio_Id = c.Int(),
                        Position_Id = c.Int(),
                    })
                .PrimaryKey(t => t.cln_employee_id)
                .ForeignKey("dbo.tbl_personeInfos", t => t.Bio_Id)
                .ForeignKey("dbo.tbl_positions", t => t.Position_Id)
                .Index(t => t.Bio_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.tbl_positions",
                c => new
                    {
                        cln_position_id = c.Int(nullable: false, identity: true),
                        cln_position_currentPosition = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cln_position_id);
            
            CreateTable(
                "dbo.tbl_equipmentInfos",
                c => new
                    {
                        cln_equipmentInfo_id = c.Int(nullable: false, identity: true),
                        cln_equipmentInfo_producer = c.String(),
                        cln_equipmentInfo_name = c.String(),
                        cln_equipmentInfo_rules = c.String(),
                        cln_equipmentInfo_purpose = c.String(),
                        Equipment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.cln_equipmentInfo_id)
                .ForeignKey("dbo.tbl_sportEquipments", t => t.Equipment_Id)
                .Index(t => t.Equipment_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_equipmentInfos", "Equipment_Id", "dbo.tbl_sportEquipments");
            DropForeignKey("dbo.tbl_employees", "Position_Id", "dbo.tbl_positions");
            DropForeignKey("dbo.tbl_employees", "Bio_Id", "dbo.tbl_personeInfos");
            DropForeignKey("dbo.tbl_sportEquipments", "ClubId", "dbo.tbl_clubs");
            DropForeignKey("dbo.tbl_clients", "cln_client_clubId", "dbo.tbl_clubs");
            DropForeignKey("dbo.tbl_clubs", "Adress_Id", "dbo.tbl_adress");
            DropForeignKey("dbo.tbl_clients", "Bio_Id", "dbo.tbl_personeInfos");
            DropForeignKey("dbo.tbl_personeInfos", "Phone_Id", "dbo.tbl_phones");
            DropForeignKey("dbo.tbl_personeInfos", "Adress_Id", "dbo.tbl_adress");
            DropForeignKey("dbo.tbl_clients", "Abonement_ClientId", "dbo.tbl_abonements");
            DropForeignKey("dbo.tbl_abonements", "AbonementType_AbonementId", "dbo.tbl_abonementsTypes");
            DropIndex("dbo.tbl_equipmentInfos", new[] { "Equipment_Id" });
            DropIndex("dbo.tbl_employees", new[] { "Position_Id" });
            DropIndex("dbo.tbl_employees", new[] { "Bio_Id" });
            DropIndex("dbo.tbl_sportEquipments", new[] { "ClubId" });
            DropIndex("dbo.tbl_clubs", new[] { "Adress_Id" });
            DropIndex("dbo.tbl_personeInfos", new[] { "Phone_Id" });
            DropIndex("dbo.tbl_personeInfos", new[] { "Adress_Id" });
            DropIndex("dbo.tbl_clients", new[] { "Bio_Id" });
            DropIndex("dbo.tbl_clients", new[] { "Abonement_ClientId" });
            DropIndex("dbo.tbl_clients", new[] { "cln_client_clubId" });
            DropIndex("dbo.tbl_abonements", new[] { "AbonementType_AbonementId" });
            DropTable("dbo.tbl_equipmentInfos");
            DropTable("dbo.tbl_positions");
            DropTable("dbo.tbl_employees");
            DropTable("dbo.tbl_sportEquipments");
            DropTable("dbo.tbl_clubs");
            DropTable("dbo.tbl_phones");
            DropTable("dbo.tbl_personeInfos");
            DropTable("dbo.tbl_clients");
            DropTable("dbo.tbl_adress");
            DropTable("dbo.tbl_abonementsTypes");
            DropTable("dbo.tbl_abonements");
        }
    }
}
