namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Cedula = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        RutaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Ruta", t => t.RutaId, cascadeDelete: true)
                .Index(t => t.RutaId);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        FacturaId = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        SubTotal = c.Single(nullable: false),
                        Total = c.Single(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        FormaDePagoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FacturaId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.FormaDePago", t => t.FormaDePagoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.FormaDePagoId);
            
            CreateTable(
                "dbo.FormaDePago",
                c => new
                    {
                        FormaDePagoId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.FormaDePagoId);
            
            CreateTable(
                "dbo.ProductoFactura",
                c => new
                    {
                        FacturaId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FacturaId, t.ProductoId })
                .ForeignKey("dbo.Factura", t => t.FacturaId, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.ProductoId, cascadeDelete: true)
                .Index(t => t.FacturaId)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Costo = c.Single(nullable: false),
                        Precio = c.Single(nullable: false),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId);
            
            CreateTable(
                "dbo.Ruta",
                c => new
                    {
                        RutaId = c.Int(nullable: false, identity: true),
                        Lugar = c.String(),
                        Dia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RutaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "RutaId", "dbo.Ruta");
            DropForeignKey("dbo.ProductoFactura", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.ProductoFactura", "FacturaId", "dbo.Factura");
            DropForeignKey("dbo.Factura", "FormaDePagoId", "dbo.FormaDePago");
            DropForeignKey("dbo.Factura", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.ProductoFactura", new[] { "ProductoId" });
            DropIndex("dbo.ProductoFactura", new[] { "FacturaId" });
            DropIndex("dbo.Factura", new[] { "FormaDePagoId" });
            DropIndex("dbo.Factura", new[] { "ClienteId" });
            DropIndex("dbo.Cliente", new[] { "RutaId" });
            DropTable("dbo.Ruta");
            DropTable("dbo.Producto");
            DropTable("dbo.ProductoFactura");
            DropTable("dbo.FormaDePago");
            DropTable("dbo.Factura");
            DropTable("dbo.Cliente");
        }
    }
}
