using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TFWEB.Models
{
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public String RazonSocial { get; set; }

        [Required]
        [StringLength(100)]
        public String Direccion { get; set; }

        [Required]
        [StringLength(11)]
        public String RUC { get; set; }

        [Required]
        public String Descripcion { get; set; }

        public Usuario user { get; set; }


    }
}