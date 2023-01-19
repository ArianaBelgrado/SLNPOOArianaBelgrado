namespace nombre_WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avions",
                c => new
                    {
                        IdAvion = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Denominacion = c.String(),
                    })
                .PrimaryKey(t => t.IdAvion);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Avions");
        }
    }
}
