using QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        public void adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        
        public TEntity obterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> obterTodos()
        {
            throw new NotImplementedException();
        }

        public void remover(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
