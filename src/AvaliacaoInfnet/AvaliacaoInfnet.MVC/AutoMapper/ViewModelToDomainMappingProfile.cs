using AutoMapper;
using AvaliacaoInfnet.Domain;

namespace AvaliacaoInfnet.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
            /*var config = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<AvaliacaoViewModel, Avaliacao>();
                cfg.CreateMap<AvaliacaoRespostaViewModel, AvaliacaoResposta>();
                cfg.CreateMap<EntrevistadoViewModel, Entrevistado>();
                cfg.CreateMap<PerfilViewModel, Perfil>();
                cfg.CreateMap<PerguntaViewModel, Pergunta>();
                cfg.CreateMap<PerguntaRespostaAvaliacaoViewModel, PerguntaRespostaAvaliacao>();
                cfg.CreateMap<TipoRespostaViewModel, TipoResposta>();
            });

            IMapper mapper = config.CreateMapper();
            
            var avaliacaoSource = new AvaliacaoViewModel();
            var avaliacaoDest = mapper.Map<AvaliacaoViewModel, Avaliacao>(avaliacaoSource);
            
            var avaliacaoRespostaSource = new AvaliacaoRespostaViewModel();
            var avaliacaoRespostaDest = mapper.Map<AvaliacaoRespostaViewModel, AvaliacaoResposta>(avaliacaoRespostaSource);
            
            var entrevistadoSource = new EntrevistadoViewModel();
            var entrevistadoDest = mapper.Map<EntrevistadoViewModel, Entrevistado>(entrevistadoSource);
            
            var perfilSource = new PerfilViewModel();
            var perfilDest = mapper.Map<PerfilViewModel, Perfil>(perfilSource);
            
            var perguntaSource = new PerguntaViewModel();
            var perguntaDest = mapper.Map<PerguntaViewModel, Pergunta>(perguntaSource);
            
            var perguntaRespostaAvaliacaoSource = new PerguntaRespostaAvaliacaoViewModel();
            var perguntaRespostaAvaliacaoDest = mapper.Map<PerguntaRespostaAvaliacaoViewModel, PerguntaRespostaAvaliacao>(perguntaRespostaAvaliacaoSource);
            
            var tipoRespostaSource = new TipoRespostaViewModel();
            var tipoRespostaDest = mapper.Map<TipoRespostaViewModel, TipoResposta>(tipoRespostaSource);*/

            //Deprecated, será removido no 5.0
            //Mapper.CreateMap<AvaliacaoViewModel, Avaliacao>();
            //Mapper.CreateMap<AvaliacaoRespostaViewModel, AvaliacaoResposta>();
            //Mapper.CreateMap<EntrevistadoViewModel, Entrevistado>();
            //Mapper.CreateMap<PerfilViewModel, Perfil>();
            //Mapper.CreateMap<PerguntaViewModel, Pergunta>();
            //Mapper.CreateMap<PerguntaRespostaAvaliacaoViewModel, PerguntaRespostaAvaliacao>();
            //Mapper.CreateMap<TipoRespostaViewModel, TipoResposta>();
        }

    }
}