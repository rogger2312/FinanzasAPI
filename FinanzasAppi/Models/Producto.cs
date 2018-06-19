namespace FinanzasAppi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Producto()
        //{
        //    Oferta = new HashSet<Oferta>();
        //    Producto_Favorito = new HashSet<Producto_Favorito>();
        //}

        public int productoid { get; set; }

        public int localid { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }

        public int cantidad { get; set; }

        public decimal precio { get; set; }

        public int categoriaid { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual Local Local { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Oferta> Oferta { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Producto_Favorito> Producto_Favorito { get; set; }
    }
}
