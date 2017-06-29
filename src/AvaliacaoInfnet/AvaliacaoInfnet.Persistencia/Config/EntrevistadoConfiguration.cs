using AvaliacaoInfnet.Domain;
using System.Data.Entity.ModelConfiguration;

namespace AvaliacaoInfnet.Persistencia.Config
{
    public class EntrevistadoConfiguration : EntityTypeConfiguration<Entrevistado>
    {
        public EntrevistadoConfiguration()
        {
            HasKey(x => x.Id);
            HasRequired(x => x.Nome);
            HasRequired(x => x.Email);
            HasRequired(a => a.Perfil);

            HasMany(x => x.Perfil);
            HasMany(x => x.AvaliacaoRespostas);
            HasMany(x => x.Avaliacoes);
        }
    }
}
