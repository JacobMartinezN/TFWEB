namespace TFWEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alltablesaddedOK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aptituds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Conocimiento = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Post_Aptitud",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nivel = c.String(nullable: false),
                        aptitud_Id = c.Int(),
                        postulante_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aptituds", t => t.aptitud_Id)
                .ForeignKey("dbo.Postulantes", t => t.postulante_Id)
                .Index(t => t.aptitud_Id)
                .Index(t => t.postulante_Id);
            
            CreateTable(
                "dbo.Post_Proyecto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Valoracion = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false),
                        postulante_Id = c.Int(),
                        proyecto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Postulantes", t => t.postulante_Id)
                .ForeignKey("dbo.Proyectoes", t => t.proyecto_Id)
                .Index(t => t.postulante_Id)
                .Index(t => t.proyecto_Id);
            
            CreateTable(
                "dbo.Proyectoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cargo = c.String(nullable: false),
                        Titulo = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                        aptitud_Id = c.Int(),
                        empresa_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aptituds", t => t.aptitud_Id)
                .ForeignKey("dbo.Empresas", t => t.empresa_Id)
                .Index(t => t.aptitud_Id)
                .Index(t => t.empresa_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Post_Proyecto", "proyecto_Id", "dbo.Proyectoes");
            DropForeignKey("dbo.Proyectoes", "empresa_Id", "dbo.Empresas");
            DropForeignKey("dbo.Proyectoes", "aptitud_Id", "dbo.Aptituds");
            DropForeignKey("dbo.Post_Proyecto", "postulante_Id", "dbo.Postulantes");
            DropForeignKey("dbo.Post_Aptitud", "postulante_Id", "dbo.Postulantes");
            DropForeignKey("dbo.Post_Aptitud", "aptitud_Id", "dbo.Aptituds");
            DropIndex("dbo.Proyectoes", new[] { "empresa_Id" });
            DropIndex("dbo.Proyectoes", new[] { "aptitud_Id" });
            DropIndex("dbo.Post_Proyecto", new[] { "proyecto_Id" });
            DropIndex("dbo.Post_Proyecto", new[] { "postulante_Id" });
            DropIndex("dbo.Post_Aptitud", new[] { "postulante_Id" });
            DropIndex("dbo.Post_Aptitud", new[] { "aptitud_Id" });
            DropTable("dbo.Proyectoes");
            DropTable("dbo.Post_Proyecto");
            DropTable("dbo.Post_Aptitud");
            DropTable("dbo.Aptituds");
        }
    }
}
