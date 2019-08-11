using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using ProHaus.PortalOnline.Dominio.Entidades;
using ProHaus.PortalOnline.Dominio.Entidades.Acesso;
using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;
using ProHaus.PortalOnline.Repositorio.Config;
using ProHaus.PortalOnline.Repositorio.Config.Acesso;
using ProHaus.PortalOnline.Repositorio.Config.Cadastro;

namespace ProHaus.PortalOnline.Repositorio.Contexto
{
    public class ProHausContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<AcessoPagina> AcessoPaginas { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<PerfilAcesso> PerfilAcessos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoProduto> TipoProdutos { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        public ProHausContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Classes de mapeamento
            
            modelBuilder.ApplyConfiguration(new AcessoPaginaConfiguration());
            modelBuilder.ApplyConfiguration(new PerfilAcessoConfiguration());
            modelBuilder.ApplyConfiguration(new UnidadeConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new FornecedorConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ContatosConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
