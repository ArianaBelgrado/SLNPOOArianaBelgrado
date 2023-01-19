namespace nombre_WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class five : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Avions", newName: "Avion");
            CreateTable(
                "dbo.ListaAerea",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdLinea);
            
            AddColumn("dbo.Avion", "IdLinea", c => c.Int(nullable: false));
            CreateIndex("dbo.Avion", "IdLinea");
            AddForeignKey("dbo.Avion", "IdLinea", "dbo.ListaAerea", "IdLinea", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "IdLinea", "dbo.ListaAerea");
            DropIndex("dbo.Avion", new[] { "IdLinea" });
            DropColumn("dbo.Avion", "IdLinea");
            DropTable("dbo.ListaAerea");
            RenameTable(name: "dbo.Avion", newName: "Avions");
        }
    }
}
