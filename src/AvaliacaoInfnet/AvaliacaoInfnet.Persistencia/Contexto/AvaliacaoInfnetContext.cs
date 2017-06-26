using AvaliacaoInfnet.Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AvaliacaoInfnet.Persistencia.Contexto
{
    public class AvaliacaoInfnetContext : DbContext
    {
        public AvaliacaoInfnetContext() : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            modelBuilder.Properties<String>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<String>().Configure(p => p.HasMaxLength(100));

            //modelBuilder.Configurations.Add(new ClienteConfiguration());
            //modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }

        public DbSet<Avaliacao> Avaliacoes { get; set; }

        public DbSet<AvaliacaoResposta> AvaliacaoRespostas { get; set; }

        public DbSet<Entrevistado> Entrevistados { get; set; }

        public DbSet<Perfil> Perfis { get; set; }

        public DbSet<Pergunta> Perguntas { get; set; }

        public DbSet<TipoResposta> TipoRespostas { get; set; }

        public DbSet<PerguntaRespostaAvaliacao> PerguntaRespostaAvaliacoes { get; set; }

    }
}
