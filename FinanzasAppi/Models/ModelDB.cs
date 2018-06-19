namespace FinanzasAppi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Flujo> Flujo { get; set; }
        public virtual DbSet<Flujo_Fijo> Flujo_Fijo { get; set; }
        public virtual DbSet<Local> Local { get; set; }
        public virtual DbSet<Oferta> Oferta { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Producto_Favorito> Producto_Favorito { get; set; }
        public virtual DbSet<Promocion> Promocion { get; set; }
        public virtual DbSet<Tips_Financieros> Tips_Financieros { get; set; }
        public virtual DbSet<Ubicacion_de_Negocio_Pequeño> Ubicacion_de_Negocio_Pequeño { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Zona> Zona { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Categoria>()
            //    .Property(e => e.descripcion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Categoria>()
            //    .Property(e => e.nombre)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Categoria>()
            //    .HasMany(e => e.Flujo)
            //    .WithRequired(e => e.Categoria)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Categoria>()
            //    .HasMany(e => e.Producto)
            //    .WithRequired(e => e.Categoria)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Empresa>()
            //    .Property(e => e.razonsocial)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Empresa>()
            //    .Property(e => e.RUC)
            //    .IsFixedLength()
            //    .IsUnicode(false);

            //modelBuilder.Entity<Empresa>()
            //    .Property(e => e.telefono)
            //    .IsFixedLength()
            //    .IsUnicode(false);

            //modelBuilder.Entity<Empresa>()
            //    .Property(e => e.paginaweb)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Empresa>()
            //    .HasMany(e => e.Local)
            //    .WithRequired(e => e.Empresa)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Flujo>()
            //    .Property(e => e.monto)
            //    .HasPrecision(6, 2);

            //modelBuilder.Entity<Flujo_Fijo>()
            //    .Property(e => e.descripcion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Flujo_Fijo>()
            //    .Property(e => e.gasto)
            //    .HasPrecision(6, 2);

            //modelBuilder.Entity<Flujo_Fijo>()
            //    .Property(e => e.tipo)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Local>()
            //    .HasMany(e => e.Producto)
            //    .WithRequired(e => e.Local)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Local>()
            //    .HasMany(e => e.Promocion)
            //    .WithRequired(e => e.Local)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Oferta>()
            //    .Property(e => e.descuento)
            //    .HasPrecision(6, 2);

            //modelBuilder.Entity<Oferta>()
            //    .Property(e => e.monto)
            //    .HasPrecision(6, 2);

            //modelBuilder.Entity<Producto>()
            //    .Property(e => e.descripcion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Producto>()
            //    .Property(e => e.precio)
            //    .HasPrecision(6, 2);

            //modelBuilder.Entity<Producto>()
            //    .HasMany(e => e.Oferta)
            //    .WithRequired(e => e.Producto)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Producto>()
            //    .HasMany(e => e.Producto_Favorito)
            //    .WithRequired(e => e.Producto)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Producto_Favorito>()
            //    .Property(e => e.descripcion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Promocion>()
            //    .Property(e => e.descripcion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Promocion>()
            //    .Property(e => e.estado)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Promocion>()
            //    .HasMany(e => e.Oferta)
            //    .WithRequired(e => e.Promocion)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Tips_Financieros>()
            //    .Property(e => e.descripcion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Ubicacion_de_Negocio_Pequeño>()
            //    .Property(e => e.descripcion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Ubicacion_de_Negocio_Pequeño>()
            //    .Property(e => e.direccion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Ubicacion_de_Negocio_Pequeño>()
            //    .Property(e => e.distrito)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Ubicacion_de_Negocio_Pequeño>()
            //    .HasMany(e => e.Flujo)
            //    .WithRequired(e => e.Ubicacion_de_Negocio_Pequeño)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Usuario>()
            //    .Property(e => e.login)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Usuario>()
            //    .Property(e => e.password)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Usuario>()
            //    .Property(e => e.nombre)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Usuario>()
            //    .Property(e => e.apellidopaterno)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Usuario>()
            //    .Property(e => e.apellidomaterno)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Usuario>()
            //    .Property(e => e.DNI)
            //    .IsFixedLength()
            //    .IsUnicode(false);

            //modelBuilder.Entity<Usuario>()
            //    .Property(e => e.celular)
            //    .IsFixedLength()
            //    .IsUnicode(false);

            //modelBuilder.Entity<Usuario>()
            //    .HasMany(e => e.Flujo)
            //    .WithRequired(e => e.Usuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Usuario>()
            //    .HasMany(e => e.Flujo_Fijo)
            //    .WithRequired(e => e.Usuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Usuario>()
            //    .HasMany(e => e.Producto_Favorito)
            //    .WithRequired(e => e.Usuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Zona>()
            //    .Property(e => e.direccion)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Zona>()
            //    .Property(e => e.distrito)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Zona>()
            //    .Property(e => e.departamento)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Zona>()
            //    .HasMany(e => e.Local)
            //    .WithRequired(e => e.Zona)
            //    .WillCascadeOnDelete(false);
        }
    }
}
