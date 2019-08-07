using ProHaus.PortalOnline.Dominio.Contratos;
using ProHaus.PortalOnline.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProHaus.PortalOnline.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        protected readonly ProHausContexto ProHausContexto;

        public BaseRepositorio(ProHausContexto proHausContexto)
        {
            ProHausContexto = proHausContexto;
        }

        public void Adicionar(TEntity entity)
        {
            ProHausContexto.Set<TEntity>().Add(entity);
            ProHausContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            ProHausContexto.Set<TEntity>().Update(entity);
            ProHausContexto.SaveChanges();
        }

        public void Dispose()
        {
            ProHausContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return ProHausContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return ProHausContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            ProHausContexto.Remove(entity);
            ProHausContexto.SaveChanges();
        }
    }
}
