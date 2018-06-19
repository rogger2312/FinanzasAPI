namespace FinanzasAppi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Empresa()
        //{
        //    Local = new HashSet<Local>();
        //}

        public int empresaid { get; set; }

        [Required]
        [StringLength(50)]
        public string razonsocial { get; set; }

        [Required]
        [StringLength(11)]
        public string RUC { get; set; }

        [Required]
        [StringLength(7)]
        public string telefono { get; set; }

        [Required]
        [StringLength(50)]
        public string paginaweb { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Local> Local { get; set; }
    }
}
