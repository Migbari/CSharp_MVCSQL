using BDProjetoRepositorioADO;
using BDProjetoRepositorioEF;

namespace BDProjetoAplicacao
{
    public class UsuarioAplicacaoConstrutor
    {
        public static UsuarioAplicacao UsuarioAppADO()
        {
            return new UsuarioAplicacao(new UsuarioAplicacaoADO());
        }
        public static UsuarioAplicacao UsuarioAppEF()
        {
            return new UsuarioAplicacao(new UsuarioRepositorioEF());
        }
    }
}
