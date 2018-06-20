using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TFWEB.Models
{
    public class Post_Aptitud
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public String Nivel { get; set; }

        public Postulante postulante { get; set; }

        public Aptitud aptitud { get; set; }
    }
}