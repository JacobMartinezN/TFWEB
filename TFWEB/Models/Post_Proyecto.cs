using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TFWEB.Models
{
    public class Post_Proyecto
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFin { get; set; }

        [Required]
        [Range(1, 5)]
        public int Valoracion { get; set; }

        [Required]
        public String Descripcion { get; set; }

        public Postulante postulante { get; set; }

        public Proyecto proyecto { get; set; }

    }
}