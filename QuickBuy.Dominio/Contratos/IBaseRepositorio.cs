using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void adicionar(TEntity entity);

        TEntity obterPorId(int id);

        IEnumerable<TEntity> obterTodos();

        void atualizar(TEntity entity);

        void remover(TEntity entity);


    }
}
