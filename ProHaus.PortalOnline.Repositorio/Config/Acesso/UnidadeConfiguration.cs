using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProHaus.PortalOnline.Dominio.Entidades.Acesso;

namespace ProHaus.PortalOnline.Repositorio.Config.Acesso
{
    public class UnidadeConfiguration : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(150);
            builder
                .Property(u => u.Logradouro)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(250);
            builder
                .Property(u => u.Numero)
                .IsRequired();
                //.HasColumnType("int");
            builder
                 .Property(u => u.Complemento)
                 //.HasColumnType("varchar")
                 .HasMaxLength(150);
            builder
                .Property(u => u.Bairro)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(100);
            builder
                .Property(u => u.CEP)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(10);
            builder
                .Property(u => u.Cidade)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(100);
            builder
                .Property(u => u.Estado)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(2);
            builder
                .Property(u => u.Telefone)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(15);
            builder
                .Property(u => u.Celular)
                .IsRequired()
               // .HasColumnType("varchar")
                .HasMaxLength(15);
            builder
                .Property(u => u.Ativo)
                .IsRequired()
                .HasColumnType("bit");
            
        }
    }
}
