using Microsoft.EntityFrameworkCore;
using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProHaus.PortalOnline.Repositorio.Config.Cadastro
{
    public class ContatosConfiguration : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(u => u.Id);
            builder
               .Property(u => u.Nome)
               .IsRequired()
               .HasMaxLength(150);
            builder
              .Property(u => u.Descricao)
              .IsRequired()
              .HasMaxLength(500);
            builder
                .Property(u => u.Telefone)
                .IsRequired()
                .HasMaxLength(15);
            builder
                .Property(u => u.Celular)
                .IsRequired()
                .HasMaxLength(15);
            builder
                .Property(u => u.Ativo)
                .IsRequired();
        }
    }
}
