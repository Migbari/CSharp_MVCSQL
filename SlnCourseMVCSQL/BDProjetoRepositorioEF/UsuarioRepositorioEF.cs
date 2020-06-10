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
        public UsuarioRepositorioEF()
        {
            bd = new DBConection();
        }
        public void Excluir(Usuario entidade)
        {
            var usuarioExcluir = bd.usuario.First(x => x.Id == entidade.Id);
            bd.Set<Usuario>().Remove(usuarioExcluir);
            bd.SaveChanges();
        }

        public Usuario ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return bd.usuario.First(x => x.Id == idInt);
        }
        public IEnumerable<Usuario> ListarTodos()
        {
            return bd.usuario;
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
            else
            {
                bd.usuario.Add(entidade);
            }
            bd.SaveChanges();
        }
    }
}
