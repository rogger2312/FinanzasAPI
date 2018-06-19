namespace FinanzasAppi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Usuario()
        //{
        //    Flujo = new HashSet<Flujo>();
        //    Flujo_Fijo = new HashSet<Flujo_Fijo>();
        //    Producto_Favorito = new HashSet<Producto_Favorito>();
        //}

        public int usuarioid { get; set; }

        [Required]
        [StringLength(50)]
        public string login { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string apellidopaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string apellidomaterno { get; set; }

        [Required]
        [StringLength(8)]
        public string DNI { get; set; }

        [Required]
        [StringLength(9)]
        public string celular { get; set; }

        public int edad { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Flujo> Flujo { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Flujo_Fijo> Flujo_Fijo { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Producto_Favorito> Producto_Favorito { get; set; }
    }
}
