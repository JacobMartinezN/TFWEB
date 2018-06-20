namespace TFWEB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {

        public DbSet<Usuario> Users { get; set; }
        public DbSet<Postulante> Postulantes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Aptitud> Aptitudes { get; set; }
        public DbSet<Post_Aptitud> Post_Aptitudes { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Post_Proyecto> Post_Proyectos { get; set; }

        public Model1()
            : base("name=Model1")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
