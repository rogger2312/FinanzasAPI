namespace FinanzasAppi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tips Financieros")]
    public partial class Tips_Financieros
    {
        [Key]
        public int tipsid { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }
    }
}
