using BDProjetoDominio;
using BDProjetoRepositorioADO;
using System.Collections.Generic;

namespace BDProjetoAplicacao
{
    public class UsuarioAplicacao
    {
        public UsuarioAplicacao()
        {
            repositorio = new UsuarioAplicacaoADO();
        }
        private UsuarioAplicacaoADO repositorio;
        public void Salvar(Usuario usuario)
        {
            repositorio.Salvar(usuario);
        }
        public void Excluir(int id)
        {
            repositorio.Excluir(id);
        }
        public List<Usuario> ListarTodos()
        {
            return repositorio.ListarTodos();
        }
        public Usuario ListarPorId(int id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}

