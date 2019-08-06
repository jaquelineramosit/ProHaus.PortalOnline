using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProHaus.PortalOnline.Dominio.Entidades.Acesso;

namespace ProHaus.PortalOnline.Repositorio.Config.Acesso
{
    public class PerfilAcessoConfiguration : IEntityTypeConfiguration<PerfilAcesso>
    {
        public void Configure(EntityTypeBuilder<PerfilAcesso> builder)
        {
            builder.HasKey(u => u.Id);
            builder
                .Property(u => u.Perfil)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(50);
            builder
                .Property(u => u.Descricao)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(150);
            builder
                .Property(u => u.Ativo)
                .IsRequired();
               // .HasColumnType("bit");
        }
    }
}
