using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//---NAHUEL GONZALEZ----
namespace Data.Models
{
    [Table("Articulo")]
    public class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string Codigo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column(TypeName = "varBinary")]
        [MaxLength(50)]
        public byte[] Imagen { get; set; }
        public int IdCategoria { get; set; }
        public int IdPresentacion { get; set; }

        public List<Detalle_ingreso> detalle_Ingresos { get; set; }
    }
}
