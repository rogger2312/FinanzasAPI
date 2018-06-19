namespace FinanzasAppi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flujo")]
    public partial class Flujo
    {
        public int flujoid { get; set; }

        public int usuarioid { get; set; }

        public decimal monto { get; set; }

        public DateTime fechainicio { get; set; }

        public DateTime fechafin { get; set; }

        public int categoriaid { get; set; }

        public int negocioid { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual Ubicacion_de_Negocio_Pequeño Ubicacion_de_Negocio_Pequeño { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
