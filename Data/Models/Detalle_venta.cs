using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//---REGULO LUNA----
namespace Data.Models
{
    [Table("detalle_venta")]
    public class Detalle_venta
    {
        [Key]
        public int Iddetalle_venta { get; set; }

        [Required]
        public int Idventa { get; set; }

        [Required]
        public int Iddetalle_ingreso { get; set; }


        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal Precio_venta { get; set; }
        public int Descuento { get; set; }

        [ForeignKey("Iddetalle_ingreso")]
        public Detalle_ingreso Detalle_ingreso { get; set; }

        [ForeignKey("Idventa")]
        public Venta Venta { get; set; }
    }
}
