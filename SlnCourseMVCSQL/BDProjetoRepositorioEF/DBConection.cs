using BDProjetoDominio;
using System.Data.Entity;

namespace BDProjetoRepositorioEF
{
    public class DBConection : DbContext
    {
        public DBConection() : base("CnxConexao")
        {

        }
        public DbSet<Usuario> usuario { get; set; }
    }
}

