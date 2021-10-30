using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    [Table("Cliente")]
    public class Cliente
    {

        [Key]
        public int Idcliente { get; set; }


        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }


        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellidos { get; set; }


        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Sexo { get; set; }


        [Column(TypeName = "date")]
        public DateTime Fecha_nacimiento { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string Tipo_documento { get; set; }


        public int Num_documento { get; set; }


        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string Direccion { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Telefono { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string Email { get; set; }

        public List<Venta> Ventas { get; set; }
    }
}
