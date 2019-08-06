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
            builder.HasKey(u => u.Id);
            builder
                .Property(p => p.TipoProdutoId)
                .IsRequired();
                //.HasColumnType("int");
            builder
                .Property(u => u.Codigo)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(100);
            builder
                .Property(u => u.ParNumber)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(2);
            builder
                .Property(u => u.Nome)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(250);
            builder
                .Property(u => u.Custo)
                .IsRequired();
            builder
                .Property(u => u.FornecedorId)
                .IsRequired();
                //.HasColumnType("int");
            builder
                .Property(u => u.Ativo)
                .IsRequired();
                //.HasColumnType("bit");
        }
    }
}
