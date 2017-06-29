using AvaliacaoInfnet.Domain;
using System.Data.Entity.ModelConfiguration;

namespace AvaliacaoInfnet.Persistencia.Config
{
    public class EntrevistadoConfiguration : EntityTypeConfiguration<Entrevistado>
    {
        public EntrevistadoConfiguration()
        {
            HasKey(x => x.Id);
        }
    }
}
