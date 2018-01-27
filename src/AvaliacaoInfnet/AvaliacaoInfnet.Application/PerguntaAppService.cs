using AvaliacaoInfnet.Application.Interface;
using AvaliacaoInfnet.Domain;
using AvaliacaoInfnet.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoInfnet.Application
{
    public class PerguntaAppService : AppServiceBase<Pergunta>, IPerguntaAppService
    {
        private readonly IPerguntaService PerguntaService;

        public PerguntaAppService(IPerguntaService serviceBase) : base(serviceBase)
        {
            PerguntaService = serviceBase;
        }
    }
}
