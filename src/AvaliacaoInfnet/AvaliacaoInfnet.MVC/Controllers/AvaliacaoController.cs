using AvaliacaoInfnet.Application.Interface;
using AvaliacaoInfnet.MVC.Mapper;
using AvaliacaoInfnet.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AvaliacaoInfnet.MVC.Controllers
{
    public class AvaliacaoController : Controller
    {
        public readonly IAvaliacaoAppService avaliacaoApp;

        public AvaliacaoController(IAvaliacaoAppService avaliacaoApp)
        {
            this.avaliacaoApp = avaliacaoApp;
        }

        // GET: Avaliacao
        public ActionResult Index()
        {
            var allAvaliacao = avaliacaoApp.GetAll().ToList();
            var avaliacaoVM = new List<AvaliacaoViewModel>();

            foreach (var avaliacao in allAvaliacao)
            {
                avaliacaoVM.Add(AvaliacaoMapper.BuildViewModelFrom(avaliacao));
            }

            return View(avaliacaoVM);
        }

        // GET: Avaliacao/Details/5
        public ActionResult Details(int id)
        {
            var avaliacao = avaliacaoApp.GetById(id);
            var avaliacaoVM = AvaliacaoMapper.BuildViewModelFrom(avaliacao);
            return View(avaliacaoVM);
        }

        // GET: Avaliacao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Avaliacao/Create
        [HttpPost]
        public ActionResult Create(AvaliacaoViewModel avaliacaoVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var avaliacao = AvaliacaoMapper.ExtractFromViewModel(avaliacaoVM);
                    avaliacaoApp.Add(avaliacao);
                    return RedirectToAction(nameof(Index));
                }

                return View(avaliacaoVM);
            }
            catch (Exception)
            {
                return View(avaliacaoVM);
            }
        }

        // GET: Avaliacao/Edit/5
        public ActionResult Edit(int id)
        {
            var avaliacao = avaliacaoApp.GetById(id);
            var avaliacaoVM = AvaliacaoMapper.BuildViewModelFrom(avaliacao);
            return View(avaliacaoVM);
        }

        // POST: Avaliacao/Edit/5
        [HttpPost]
        public ActionResult Edit(AvaliacaoViewModel avaliacaoVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var avaliacao = AvaliacaoMapper.ExtractFromViewModel(avaliacaoVM);
                    avaliacaoApp.Update(avaliacao);
                    return RedirectToAction(nameof(Index));
                }

                return View(avaliacaoVM);
            }
            catch (Exception)
            {
                return View(avaliacaoVM);
            }
        }

        // GET: Avaliacao/Delete/5
        public ActionResult Delete(int id)
        {
            var avaliacao = avaliacaoApp.GetById(id);

            var avaliacaoVM = AvaliacaoMapper.BuildViewModelFrom(avaliacao);

            if (avaliacaoVM == null)
            {
                return HttpNotFound();
            }

            return View(avaliacaoVM);
        }

        // POST: Avaliacao/Delete/5
        [HttpPost]
        public ActionResult DeletePost(int id)
        {
            avaliacaoApp.Remove(avaliacaoApp.GetById(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
