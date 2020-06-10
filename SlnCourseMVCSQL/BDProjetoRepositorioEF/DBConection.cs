using BDProjetoDominio;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BDProjetoRepositorioEF
{
    public class DBConection : DbContext
    {
        public DBConection() : base("CnxConexao")
        {

        }
        public DbSet<Usuario> usuario { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(45);
            modelBuilder.Entity<Usuario>().Property(x => x.Cargo).IsRequired().HasColumnType("varchar").HasMaxLength(45);
            modelBuilder.Entity<Usuario>().Property(x => x.Data).IsRequired().HasColumnType("date");
        }   
    }
}

