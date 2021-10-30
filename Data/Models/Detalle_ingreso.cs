using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//---ROCIO AGUSTI----
namespace Data.Models
{
    [Table("Detalle_ingreso")]
    public class Detalle_ingreso
    {
        [Key]
        public int IdDetalle_ingreso { get; set; }
        public int IdIngreso { get; set; }
        public int IdArticulo { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Precio_compra { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Precio_venta { get; set; }
        [Required]
        public int Stock_inicial { get; set; }
        [Required]
        public int Stock_actual { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Fecha_produccion { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Fecha_vencimiento { get; set; }

        //prop de navegacion
        public List<Detalle_venta> Detalle_venta { get; set; }
        [ForeignKey("IdArticulo")]
        public Articulo Articulo { get; set; }
    }
}
