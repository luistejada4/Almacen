namespace DAL
{
    using Entidades;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using System.Data.Entity.Core.Objects;

    public class Database : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FormaDePago> FormasDePagos { get; set; }
        public DbSet<ProductoFactura> PeroductosFacturas { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        public Database()
            : base("ConStr")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<ProductoFactura>()
                .HasKey(x => new { x.FacturaId, x.ProductoId });

        
         
        }

        public void Refresh(RefreshMode clientWins, object articles)
        {
            this.Refresh(clientWins, articles);
        }
    }
}