namespace FinanzasAppi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Producto_Favorito
    {
        [Key]
        public int productofavoritoid { get; set; }

        public int productoid { get; set; }

        public int usuarioid { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
