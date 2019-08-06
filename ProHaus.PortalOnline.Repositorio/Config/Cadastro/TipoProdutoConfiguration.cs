using Microsoft.EntityFrameworkCore;
using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ProHaus.PortalOnline.Repositorio.Config.Cadastro
{
    public class TipoProdutoConfiguration : IEntityTypeConfiguration<TipoProduto>
    {
        public void Configure(EntityTypeBuilder<TipoProduto> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(150);

            builder
                .Property(u => u.Ativo)
                .IsRequired();
                //.HasColumnType("bit");
        }
    }
}
