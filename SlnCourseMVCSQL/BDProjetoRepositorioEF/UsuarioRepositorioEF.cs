using BDProjetoDominio;
using BDProjetoDominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BDProjetoRepositorioEF
{
    public class UsuarioRepositorioEF : IRepositorio<Usuario>
    {
        private readonly DBConection bd;

        public void Excluir(Usuario entidade)
        {
            throw new NotImplementedException();
        }

        public Usuario ListarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Usuario entidade)
        {
            if (entidade.Id > 0)
            {
                var usuarioAlterar = bd.usuario.First(x => x.Id == entidade.Id);
                usuarioAlterar.Nome = entidade.Nome;
                usuarioAlterar.Cargo = entidade.Cargo;
                usuarioAlterar.Data = entidade.Data;
            }
            bd.SaveChanges();
        }
    }
}
