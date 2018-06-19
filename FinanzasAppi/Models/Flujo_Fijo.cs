namespace FinanzasAppi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flujo Fijo")]
    public partial class Flujo_Fijo
    {
        [Key]
        public int flujofijoid { get; set; }

        public int usuarioid { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }

        public decimal gasto { get; set; }

        public DateTime fechainicio { get; set; }

        public DateTime fechafin { get; set; }

        [Required]
        [StringLength(50)]
        public string tipo { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
