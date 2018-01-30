using AvaliacaoInfnet.Application.Interface;
using AvaliacaoInfnet.Web.Mapper;
using AvaliacaoInfnet.Web.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace AvaliacaoInfnet.Web.Controllers
{
    public class EntrevistadoController : Controller
    {
        public readonly IEntrevistadoAppService entrevistadoApp;
        public readonly IPerfilAppService perfilApp;

        public EntrevistadoController(IEntrevistadoAppService entrevistadoApp, IPerfilAppService perfilApp)
        {
            this.entrevistadoApp = entrevistadoApp;
            this.perfilApp = perfilApp;
        }

        // GET: Entrevisatado
        public ActionResult Index()
        {
            var viewModelResponse = new List<EntrevistadoViewModel>();
            var allEntrevistados = entrevistadoApp.GetAll();
            var allPerfil = perfilApp.GetAll().ToList();

            foreach (var entrevistado in allEntrevistados)
            {
                viewModelResponse.Add(EntrevistadoMapper.BuildViewModelFrom(entrevistado, allPerfil));
            }

            return View(viewModelResponse);
        }

        // GET: Entrevisatado/Details/5
        public ActionResult Details(int id)
        {
            var allPerfil = perfilApp.GetAll().ToList();
            var viewModelResponse = EntrevistadoMapper.BuildViewModelFrom(entrevistadoApp.GetById(id), allPerfil);
            return View(viewModelResponse);
        }

        // GET: Entrevisatado/Create
        public ActionResult Create()
        {
            var perfilList = new List<SelectListItem>();
            var allPerfis = perfilApp.GetAll();

            foreach (var perfil in allPerfis)
            {
                perfilList.Add(new SelectListItem
                {
                    Text = perfil.Descricao,
                    Selected = false,
                    Value = perfil.Id.ToString(),
                });
            }

            ViewBag.PerfilList = perfilList;

            return View();
        }

        // POST: Entrevisatado/Create
        [HttpPost]
        public ActionResult Create(EntrevistadoViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    entrevistadoApp.Add(EntrevistadoMapper.ExtractFromViewModel(viewModel));
                    return RedirectToAction(nameof(Index));
                }

                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: Entrevisatado/Edit/5
        public ActionResult Edit(int id)
        {
            var entrevistado = entrevistadoApp.GetById(id);
            var viewModelResponse = EntrevistadoMapper.BuildViewModelFrom(entrevistado, null);

            return View(viewModelResponse);
        }

        // POST: Entrevisatado/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EntrevistadoViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entrevistado = EntrevistadoMapper.ExtractFromViewModel(viewModel);
                    entrevistado.Id = id;
                    entrevistadoApp.Update(entrevistado);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: Entrevisatado/Delete/5
        public ActionResult Delete(int id)
        {
            var viewModelResponse = EntrevistadoMapper.BuildViewModelFrom(entrevistadoApp.GetById(id), null);

            return View(viewModelResponse);
        }

        // POST: Entrevisatado/Delete/5
        [HttpPost]
        public ActionResult DeletePost(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    entrevistadoApp.Remove(entrevistadoApp.GetById(id));

                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}