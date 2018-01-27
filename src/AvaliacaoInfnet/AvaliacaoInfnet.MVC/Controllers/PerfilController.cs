using AvaliacaoInfnet.Application.Interface;
using System.Linq;
using System.Web.Mvc;

namespace AvaliacaoInfnet.MVC.Controllers
{
    public class PerfilController : Controller
    {
        private readonly IPerfilAppService perfilApp;

        public PerfilController(IPerfilAppService perfilApp)
        {
            this.perfilApp = perfilApp;
        }

        // GET: Perfil
        public ActionResult Index()
        {
            var allPerfis = perfilApp.GetAll().ToList();
            return View(allPerfis);
        }
    }
}