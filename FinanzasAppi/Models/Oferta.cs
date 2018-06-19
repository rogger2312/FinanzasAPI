namespace FinanzasAppi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Oferta")]
    public partial class Oferta
    {
        public int ofertaid { get; set; }

        public int productoid { get; set; }

        public int promocionid { get; set; }

        public int cantidad { get; set; }

        public decimal descuento { get; set; }

        public decimal monto { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Promocion Promocion { get; set; }
    }
}
