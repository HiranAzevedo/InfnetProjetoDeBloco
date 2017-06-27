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

            //Relação 1:N -> Entrevisto PRECISA TER um perfil e 1 perfil pode ter N Entrevistados
            HasRequired(a => a.Perfil)
                .WithMany()
                .Map(m => m.MapKey("PerfilId"));

            //Relação 1:1 -> Aluno x Usuário
            //HasRequired(a => a.Usuario)
            //    .WithRequiredPrincipal();
        }
    }
}
