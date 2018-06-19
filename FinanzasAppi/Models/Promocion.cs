namespace FinanzasAppi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Promocion")]
    public partial class Promocion
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Promocion()
        //{
        //    Oferta = new HashSet<Oferta>();
        //}

        public int promocionid { get; set; }

        public int localid { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }

        public DateTime fechainicio { get; set; }

        public DateTime fechafin { get; set; }

        [Required]
        [StringLength(50)]
        public string estado { get; set; }

        public virtual Local Local { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Oferta> Oferta { get; set; }
    }
}
