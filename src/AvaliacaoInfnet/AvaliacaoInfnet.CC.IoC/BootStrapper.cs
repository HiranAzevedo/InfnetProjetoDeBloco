using AvaliacaoInfnet.Application;
using AvaliacaoInfnet.Application.Interface;
using AvaliacaoInfnet.Domain.Interfaces.Repositorio;
using AvaliacaoInfnet.Domain.Interfaces.Service;
using AvaliacaoInfnet.Domain.Services;
using AvaliacaoInfnet.Persistencia.Context;
using AvaliacaoInfnet.Persistencia.Repository;
using SimpleInjector;

namespace AvaliacaoInfnet.CC.IoC
{
    public class BootStrapper
    {

        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            //App
            container.Register<IAvaliacaoAppService, AvaliacaoAppService>(Lifestyle.Scoped);
            container.Register<IPerfilAppService, PerfilAppService>(Lifestyle.Scoped);
            container.Register<IPerguntaAppService, PerguntaAppService>(Lifestyle.Scoped);
            container.Register<IEntrevistadoAppService, EntrevistadoAppService>(Lifestyle.Scoped);
            container.Register<ITipoRespostaAppService,TipoRespostaAppService>(Lifestyle.Scoped);

            //Domain
            container.Register<IAvaliacaoService, AvaliacaoService>(Lifestyle.Scoped);
            container.Register<IPerguntaService, PerguntaService>(Lifestyle.Scoped);
            container.Register<IPerfilService, PerfilService>(Lifestyle.Scoped);
            container.Register<IEntrevistadoService, EntrevistadoService>(Lifestyle.Scoped);
            container.Register<ITipoRespostaService, TipoRespostaService>(Lifestyle.Scoped);

            //Infra
            container.Register<IAvaliacaoRepository, AvaliacaoRepository>(Lifestyle.Scoped);
            container.Register<IPerguntaRepository, PerguntaRepository>(Lifestyle.Scoped);
            container.Register<IPerfilRepository, PerfilRepository>(Lifestyle.Scoped);
            container.Register<IEntrevistadoRepository, EntrevistadoRepository>(Lifestyle.Scoped);
            container.Register<ITipoRespostaRepository, TipoRespostaRepository>(Lifestyle.Scoped);
            container.Register<AvaliacaoInfnetContext>(Lifestyle.Scoped);
        }
    }
}