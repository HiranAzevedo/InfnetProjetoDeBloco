using AvaliacaoInfnet.Application.Interface;
using AvaliacaoInfnet.MVC.Mapper;
using AvaliacaoInfnet.MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace AvaliacaoInfnet.MVC.Controllers
{
    public class PerguntaController : Controller
    {
        public readonly IPerguntaAppService perguntaApp;

        public PerguntaController(IPerguntaAppService perguntaApp)
        {
            this.perguntaApp = perguntaApp;
        }

        public ActionResult Index()
        {
            var allPerguntas = perguntaApp.GetAll().ToList();
            var perguntas = new List<PerguntaViewModel>();

            for (int i = 0; i < allPerguntas.Count; i++)
            {
                perguntas.Add(PerguntaMapper.BuildViewModelFrom(allPerguntas[i]));
            }

            return View(perguntas);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pergunta = perguntaApp.GetById(id.Value);
            var perguntaViewModel = PerguntaMapper.BuildViewModelFrom(pergunta);

            if (pergunta == null)
            {
                return HttpNotFound();
            }

            return View(perguntaViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var perguntaViewModel = PerguntaMapper.BuildViewModelFrom(perguntaApp.GetById(id.Value));

            if (perguntaViewModel == null)
            {
                return HttpNotFound();
            }
            return View(perguntaViewModel);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdConta,Nome,SobreNome,NomeUsuario,Senha,Local")] PerguntaViewModel perguntaViewModel)
        {
            if (ModelState.IsValid)
            {
                var pergunta = PerguntaMapper.ExtractFromViewModel(perguntaViewModel);
                perguntaApp.Update(pergunta);

                return RedirectToAction(nameof(Index));
            }
            return View(perguntaViewModel);
        }

        // GET: Perfil/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pergunta = perguntaApp.GetById(id.Value);

            var perguntaViewModel = PerguntaMapper.BuildViewModelFrom(pergunta);

            if (perguntaViewModel == null)
            {
                return HttpNotFound();
            }

            return View(perguntaViewModel);
        }

        // POST: Perfil/Delete/5
        [HttpPost, ActionName(nameof(Delete))]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            perguntaApp.Remove(perguntaApp.GetById(id));
            return RedirectToAction(nameof(Index));
        }
    }
}