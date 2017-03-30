namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Forma : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Factura", "UsuarioId", "dbo.Usuario");
            DropIndex("dbo.Factura", new[] { "UsuarioId" });
            RenameColumn(table: "dbo.Factura", name: "UsuarioId", newName: "Usuario_UsuarioId");
            AlterColumn("dbo.Factura", "Usuario_UsuarioId", c => c.Int());
            CreateIndex("dbo.Factura", "Usuario_UsuarioId");
            AddForeignKey("dbo.Factura", "Usuario_UsuarioId", "dbo.Usuario", "UsuarioId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factura", "Usuario_UsuarioId", "dbo.Usuario");
            DropIndex("dbo.Factura", new[] { "Usuario_UsuarioId" });
            AlterColumn("dbo.Factura", "Usuario_UsuarioId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Factura", name: "Usuario_UsuarioId", newName: "UsuarioId");
            CreateIndex("dbo.Factura", "UsuarioId");
            AddForeignKey("dbo.Factura", "UsuarioId", "dbo.Usuario", "UsuarioId", cascadeDelete: true);
        }
    }
}
