using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//---ORNELLA OLIVASTRI----
namespace Data.Models
{
    [Table("Venta")]

    public class Venta
    {

        [Key]
        public int idventa { get; set; }

        [Required]
        public int idcliente { get; set; }

        [Required]
        public int idtrabajador { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string tipo_comprobante { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string serie { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string correlativo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string igv { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string estado { get; set; }



        //ForeignKeys

        [ForeignKey("idcliente")]
        public Cliente cliente { get; set; }

        public List<Detalle_venta> detalle_venta { get; set; }

        [ForeignKey("idtrabajador")]
        public Trabajador trabajador { get; set; } 
    }
}
