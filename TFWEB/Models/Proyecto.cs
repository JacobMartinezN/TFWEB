using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TFWEB.Models
{
    public class Proyecto
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public String Cargo { get; set; }

        [Required]
        public String Titulo { get; set; }

        [Required]
        public String Descripcion { get; set; }

        [Required]
        public String Estado { get; set; }

        public Empresa empresa { get; set; }

        public Aptitud aptitud { get; set; }

    }
}