using System;
using System.Collections.Generic;
using System.Text;

namespace ProHaus.PortalOnline.Dominio.Contratos
{
    /// <summary>
    /// Definindo uma interface de nome IRepositorio, que vai trabalhar com o tipo TEntity que é uma class. Herda da Interface IDisposable.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();

    }
}
