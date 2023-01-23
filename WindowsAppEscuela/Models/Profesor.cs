using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppEscuela.Models;

namespace WindowsAppEscuela
{
    [Table("Profesor")]
    public class Profesor
    {
        [Key]
        public int IDProfesor { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }
        public int IDLocalidad { get; set; }

        [ForeignKey("IDLocalidad")]
        public Localidad Localidad { get; set; }
    }
}
