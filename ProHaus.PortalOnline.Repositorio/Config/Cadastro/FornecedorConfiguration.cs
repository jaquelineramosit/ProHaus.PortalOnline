using Microsoft.EntityFrameworkCore;
using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ProHaus.PortalOnline.Repositorio.Config.Cadastro
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(150);
            builder
                .Property(u => u.Cidade)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(150);
            builder
                .Property(u => u.Estado)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(150);
            builder
                .Property(u => u.Telefone)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(15);
            builder
                .Property(u => u.Skype)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(100);
            builder
                .Property(u => u.CNPJ)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(14);
            builder
                .Property(u => u.Ativo)
                .IsRequired();
                //.HasColumnType("bit");
        }
    }
}
