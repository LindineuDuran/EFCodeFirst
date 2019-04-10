using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EFCodeFirst.Models;

namespace EFCodeFirst.DAL
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFCodeFirstContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Universidade> Universidades { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
    }
}