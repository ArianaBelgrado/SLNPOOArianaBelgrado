namespace nombre_WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class six : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ListaAerea", newName: "LineaAerea");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.LineaAerea", newName: "ListaAerea");
        }
    }
}
