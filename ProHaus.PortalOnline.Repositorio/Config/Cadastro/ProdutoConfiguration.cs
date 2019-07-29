using Microsoft.EntityFrameworkCore;
using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ProHaus.PortalOnline.Repositorio.Config.Cadastro
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
       
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            throw new NotImplementedException();
        }
    }
}
