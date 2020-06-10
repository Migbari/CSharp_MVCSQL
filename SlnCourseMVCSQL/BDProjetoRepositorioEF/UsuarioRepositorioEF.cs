using BDProjetoDominio;
using BDProjetoDominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProjetoRepositorioEF
{
    public class UsuarioRepositorioEF : IRepositorio<Usuario>
    {
        void IRepositorio<Usuario>.Excluir(Usuario entidade)
        {
            throw new NotImplementedException();
        }

        Usuario IRepositorio<Usuario>.ListarPorId(string id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Usuario> IRepositorio<Usuario>.ListarTodos()
        {
            throw new NotImplementedException();
        }

        void IRepositorio<Usuario>.Salvar(Usuario entidade)
        {
            throw new NotImplementedException();
        }
    }
}
