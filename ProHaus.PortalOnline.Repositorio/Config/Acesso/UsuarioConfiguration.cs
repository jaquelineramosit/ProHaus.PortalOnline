using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProHaus.PortalOnline.Dominio.Entidades.Acesso;

namespace ProHaus.PortalOnline.Repositorio.Config.Acesso
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //qual a propriedade de usuario que vai ser mapeada pela chave primaria da tabela
            //utiliza padrão fluent, ou seja, essa forma encadeada
            builder.HasKey(u => u.Id);
            
            builder
                .Property(u => u.Login)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(150);
            builder
                .Property(u => u.Senha)
                .IsRequired()
                //.HasColumnType("varchar")
                .HasMaxLength(400);
            builder
                .Property(u => u.Ativo)
                .IsRequired();
                //.HasColumnType("Bit");
            builder
                .Property(u => u.UnidadeId)
                .IsRequired();
                //.HasColumnType("int");
            builder
                .Property(u => u.Nome)
                //.HasColumnType("varchar")
                .HasMaxLength(100);
            builder
                .Property(u => u.Sobrenome)
                //.HasColumnType("varchar")
                .HasMaxLength(150);
            builder
                .Property(u => u.PerfilAcessoId);
                //.HasColumnType("int");
            
        }
    }
}
