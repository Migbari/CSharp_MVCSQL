using BDProjetoRepositorioADO;

namespace BDProjetoAplicacao
{
    public class UsuarioAplicacaoConstrutor
    {
        public static UsuarioAplicacao UsuarioAppADO()
        {
            return new UsuarioAplicacao(new UsuarioAplicacaoADO());
        }
    }
}
