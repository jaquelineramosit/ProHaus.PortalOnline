using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProHaus.PortalOnline.Dominio.Entidades.Acesso;

namespace ProHaus.PortalOnline.Repositorio.Config
{
    public class AcessoPaginaConfiguration : IEntityTypeConfiguration<AcessoPagina>
    {
        public void Configure(EntityTypeBuilder<AcessoPagina> builder)
        {
            builder.HasKey(u => u.Id);
            builder
                .Property(u => u.PerfilAcessoId)
                .IsRequired();
                //.HasColumnType("int");
            builder
                .Property(u => u.NomePagina)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(100);
            builder
                .Property(u => u.SubPagina)
                //.HasColumnType("varchar")
                .HasMaxLength(100);
            builder
                .Property(u => u.Funcao)
                //.HasColumnType("varchar")
                .HasMaxLength(100);
            builder
                .Property(u => u.Ativo)
                .IsRequired();
               // .HasColumnType("bit");
        }
    }
}
