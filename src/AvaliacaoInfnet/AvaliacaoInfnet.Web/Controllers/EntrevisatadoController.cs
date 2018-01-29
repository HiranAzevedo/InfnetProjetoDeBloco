using AvaliacaoInfnet.Application.Interface;
using AvaliacaoInfnet.Web.Mapper;
using AvaliacaoInfnet.Web.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AvaliacaoInfnet.Web.Controllers
{
    public class EntrevisatadoController : Controller
    {
        public readonly IEntrevistadoAppService entrevistadoApp;

        // GET: Entrevisatado
        public ActionResult Index()
        {
            var viewModelResponse = new List<EntrevistadoViewModel>();
            var allEntrevistados = entrevistadoApp.GetAll();

            //TODO colocar todos os valores ja existentes aqui de perfil
            foreach (var entrevistado in allEntrevistados)
            {
                viewModelResponse.Add(EntrevistadoMapper.BuildViewModelFrom(entrevistado, new Dictionary<int, string>()));
            }

            return View(viewModelResponse);
        }

        // GET: Entrevisatado/Details/5
        public ActionResult Details(int id)
        {
            var viewModelResponse = EntrevistadoMapper.BuildViewModelFrom(entrevistadoApp.GetById(id), new Dictionary<int, string>());
            return View(viewModelResponse);
        }

        // GET: Entrevisatado/Create
        public ActionResult Create()
        {
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
            var viewModelResponse = EntrevistadoMapper.BuildViewModelFrom(entrevistado, new Dictionary<int, string>());

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
            var viewModelResponse = EntrevistadoMapper.BuildViewModelFrom(entrevistadoApp.GetById(id), new Dictionary<int, string>());

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