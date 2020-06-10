using System.Data.Entity;

namespace BDProjetoRepositorioEF
{
    public class MyConfiguration : DbConfiguration
    {
        public MyConfiguration()
        {
            SetProviderServices(System.Data.Entity.SqlServer.SqlProviderServices.ProviderInvariantName,
            System.Data.Entity.SqlServer.SqlProviderServices.Instance);
        }
    }
}
