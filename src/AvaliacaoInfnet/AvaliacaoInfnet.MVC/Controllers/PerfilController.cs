﻿using AvaliacaoInfnet.Application.Interface;
using AvaliacaoInfnet.MVC.Mapper;
using AvaliacaoInfnet.MVC.Models;
using System.Linq;
using System.Net;
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

        // GET: Perfil/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var perfil = perfilApp.GetById(id.Value);

            var perfilViewModel = PerfilMapper.BuildViewModelFromPerfil(perfil);

            if (perfil == null)
            {
                return HttpNotFound();
            }

            return View(perfilViewModel);
        }

        // GET: Perfil/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perfil/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nome,SobreNome,NomeUsuario,Senha,Local")] PerfilViewModel perfilViewModel)
        {
            if (ModelState.IsValid)
            {
              
                var perfil = PerfilMapper.ExtractPerfilFromViewModel(perfilViewModel);

                perfilApp.Add(perfil);

                return RedirectToAction(nameof(Index));
            }

            return View(perfilViewModel);
        }

        // GET: Perfil/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var perfilViewModel = PerfilMapper.BuildViewModelFromPerfil( perfilApp.GetById(id.Value));

            if (perfilViewModel == null)
            {
                return HttpNotFound();
            }

            return View(perfilViewModel);
        }

        // POST: Perfil/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdConta,Nome,SobreNome,NomeUsuario,Senha,Local")] PerfilViewModel perfilViewModel)
        {
            if (ModelState.IsValid)
            {
                var perfil = PerfilMapper.ExtractPerfilFromViewModel(perfilViewModel);
                perfilApp.Update(perfil);

                return RedirectToAction(nameof(Index));
            }
            return View(perfilViewModel);
        }

        // GET: Perfil/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var perfil = perfilApp.GetById(id.Value);

            var perfilViewModel = PerfilMapper.BuildViewModelFromPerfil( perfil);

            if (perfilViewModel == null)
            {
                return HttpNotFound();
            }

            return View(perfilViewModel);
        }

        // POST: Perfil/Delete/5
        [HttpPost, ActionName(nameof(Delete))]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            perfilApp.Remove(perfilApp.GetById(id));
            return RedirectToAction(nameof(Index));
        }
    }
}