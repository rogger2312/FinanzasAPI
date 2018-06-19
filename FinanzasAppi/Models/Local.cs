namespace FinanzasAppi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Local")]
    public partial class Local
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Local()
        //{
        //    Producto = new HashSet<Producto>();
        //    Promocion = new HashSet<Promocion>();
        //}

        public int localid { get; set; }

        public int empresaid { get; set; }

        public int zonaid { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Zona Zona { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Producto> Producto { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Promocion> Promocion { get; set; }
    }
}
