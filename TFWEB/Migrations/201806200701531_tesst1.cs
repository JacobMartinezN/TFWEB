namespace TFWEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tesst1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RazonSocial = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 100),
                        RUC = c.String(nullable: false, maxLength: 11),
                        Descripcion = c.String(nullable: false),
                        user_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.user_Id)
                .Index(t => t.user_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empresas", "user_Id", "dbo.Usuarios");
            DropIndex("dbo.Empresas", new[] { "user_Id" });
            DropTable("dbo.Empresas");
        }
    }
}
