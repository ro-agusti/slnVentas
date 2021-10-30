using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    [Table("Trabajador")]
    public class Trabajador
    {
        [Key]
        public int Idtrabajador { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellidos { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(12)]
        public string Sexo { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_nacimiento { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(12)]

        public string Num_documento { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Direccion { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]

        public string Telefono { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Acceso { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(12)]
        public string Usuario { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Password { get; set; }


        public List<Venta> ventas { get; set; }
    }
}
