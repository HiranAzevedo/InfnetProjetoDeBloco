using AutoMapper;
using AvaliacaoInfnet.Domain;

namespace AvaliacaoInfnet.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            /*var config = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<Avaliacao, AvaliacaoViewModel>();
                cfg.CreateMap<AvaliacaoResposta, AvaliacaoRespostaViewModel>();
                cfg.CreateMap<Entrevistado, EntrevistadoViewModel>();
                cfg.CreateMap<Perfil, PerfilViewModel>();
                cfg.CreateMap<Pergunta, PerguntaViewModel>();
                cfg.CreateMap<PerguntaRespostaAvaliacao, PerguntaRespostaAvaliacaoViewModel>();
                cfg.CreateMap<TipoResposta, TipoRespostaViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            
            var avaliacaoSource = new Avaliacao();
            var avaliacaoDest = mapper.Map<Avaliacao, AvaliacaoViewModel>(avaliacaoSource);
            
            var avaliacaoRespostaSource = new AvaliacaoResposta();
            var avaliacaoRespostaDest = mapper.Map<AvaliacaoResposta, AvaliacaoRespostaViewModel>(avaliacaoRespostaSource);
            
            var entrevistadoSource = new Entrevistado();
            var entrevistadoDest = mapper.Map<Entrevistado, EntrevistadoViewModel>(entrevistadoSource);
            
            var perfilSource = new Perfil();
            var perfilDest = mapper.Map<Perfil, PerfilViewModel>(perfilSource);
            
            var perguntaSource = new Pergunta();
            var perguntaDest = mapper.Map<Pergunta, PerguntaViewModel>(perguntaSource);
            
            var perguntaRespostaAvaliacaoSource = new PerguntaRespostaAvaliacao();
            var perguntaRespostaAvaliacaoDest = mapper.Map<PerguntaRespostaAvaliacao, PerguntaRespostaAvaliacaoViewModel>(perguntaRespostaAvaliacaoSource);
            
            var tipoRespostaSource = new TipoResposta();
            var tipoRespostaDest = mapper.Map<TipoResposta, TipoRespostaViewModel>(tipoRespostaSource);*/

            //Deprecated, será removido no 5.0
            //Mapper.CreateMap<Avaliacao, AvaliacaoViewModel>();
            //Mapper.CreateMap<AvaliacaoResposta, AvaliacaoRespostaViewModel>();
            //Mapper.CreateMap<Entrevistado, EntrevistadoViewModel>();
            //Mapper.CreateMap<Perfil, PerfilViewModel>();
            //Mapper.CreateMap<Pergunta, PerguntaViewModel>();
            //Mapper.CreateMap<PerguntaRespostaAvaliacao, PerguntaRespostaAvaliacaoViewModel>();
            //Mapper.CreateMap<TipoResposta, TipoRespostaViewModel>();
        }

    }
}