using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppEscuela.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        [Key]
        public int IDEstudiante { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Telefono { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int IDLocalidad { get; set; }

        [ForeignKey("IDLocalidad")]
        public Localidad Localidad { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

    }
}
