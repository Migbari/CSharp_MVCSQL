using System.Collections;
using System.Collections.Generic;

namespace BDProjetoDominio.Interface
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        void Salvar(TEntity entidade);
        void Excluir(TEntity entidade);
        IEnumerable<TEntity> ListarTodos();
        TEntity ListarPorId(string id);
    }
}
