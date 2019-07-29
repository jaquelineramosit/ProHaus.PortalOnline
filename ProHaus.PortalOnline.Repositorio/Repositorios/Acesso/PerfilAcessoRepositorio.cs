using ProHaus.PortalOnline.Dominio.Contratos.Acesso;
using ProHaus.PortalOnline.Dominio.Entidades;
using ProHaus.PortalOnline.Dominio.Entidades.Acesso;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProHaus.PortalOnline.Repositorio.Repositorios.Acesso
{
    public class PerfilAcessoRepositorio : BaseRepositorio<PerfilAcesso>, IPerfilAcessoRepositorio
    {
        public void Adicionar(PerfilAcesso entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(PerfilAcesso entity)
        {
            throw new NotImplementedException();
        }

        public void Remover(PerfilAcesso entity)
        {
            throw new NotImplementedException();
        }

        PerfilAcesso Dominio.Contratos.IRepositorio<PerfilAcesso>.ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<PerfilAcesso> Dominio.Contratos.IRepositorio<PerfilAcesso>.ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
