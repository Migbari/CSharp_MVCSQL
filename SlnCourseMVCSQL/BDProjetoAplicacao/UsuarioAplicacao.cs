using BDProjetoDominio;
using BDProjetoDominio.Interface;
using BDProjetoRepositorioADO;
using System.Collections.Generic;

namespace BDProjetoAplicacao
{
    public class UsuarioAplicacao
    {
        private readonly IRepositorio<Usuario> repositorio;
        public UsuarioAplicacao(IRepositorio<Usuario> repos)
        {
            repositorio = repos;
        }
        public void Salvar(Usuario usuario)
        {
            repositorio.Salvar(usuario);
        }
        public void Excluir(Usuario usuario)
        {
            repositorio.Excluir(usuario);
        }
        public IEnumerable<Usuario> ListarTodos()
        {
            return repositorio.ListarTodos();
        }
        public Usuario ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}

