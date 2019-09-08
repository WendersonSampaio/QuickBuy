using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContexto quickBuyContexto;

        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            quickBuyContexto = this.quickBuyContexto;
        }

        public void adicionar(TEntity entity)
        {
            this.quickBuyContexto.Set<TEntity>().Add(entity);
            this.quickBuyContexto.SaveChanges();
        }

        public void atualizar(TEntity entity)
        {
            this.quickBuyContexto.Set<TEntity>().Update(entity);
            this.quickBuyContexto.SaveChanges();
        }
                
        public TEntity obterPorId(int id)
        {
            return this.quickBuyContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> obterTodos()
        {
            return this.quickBuyContexto.Set<TEntity>().ToList();
        }

        public void remover(TEntity entity)
        {
            this.quickBuyContexto.Set<TEntity>().Remove(entity);
            this.quickBuyContexto.SaveChanges();
        }

        public void Dispose()
        {
            try
            {
                this.quickBuyContexto.Dispose();
            }
            catch (Exception ex)
            {

                
            }
            
        }
    }
}
