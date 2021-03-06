﻿using CourseRating.Application.Interface;
using CourseRating.Web.Mapper;
using CourseRating.Web.ViewModels;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CourseRating.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioAppService _service;

        public UsuarioController(IUsuarioAppService usuarioApp)
        {
            _service = usuarioApp;
        }

        // GET: Usuario
        public ActionResult Index() => View(_service.GetAll().Select(UsuarioMapper.BuildViewModelFrom));

        // GET: Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var usuarioViewModel = UsuarioMapper.BuildViewModelFrom(_service.GetById(id.Value));

            if (usuarioViewModel == null)
            {
                return HttpNotFound();
            }
            return View(usuarioViewModel);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Login,Senha,TipoUsuario")] UsuarioViewModel usuarioViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(usuarioViewModel);
            }

            var usuario = UsuarioMapper.ExtractFromViewModel(usuarioViewModel);
            _service.Add(usuario);

            return RedirectToAction(nameof(Index));

        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var usuarioViewModel = UsuarioMapper.BuildViewModelFrom(_service.GetById(id.Value));

            if (usuarioViewModel == null)
            {
                return HttpNotFound();
            }

            return View(usuarioViewModel);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Login,Senha,TipoUsuario")] UsuarioViewModel usuarioViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(usuarioViewModel);
            }

            var usuario = UsuarioMapper.ExtractFromViewModel(usuarioViewModel);
            _service.Update(usuario);

            return RedirectToAction(nameof(Details), new { id = usuario.Id });
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var usuarioViewModel = UsuarioMapper.BuildViewModelFrom(_service.GetById(id.Value));

            if (usuarioViewModel == null)
            {
                return HttpNotFound();
            }

            return View(usuarioViewModel);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _service.Remove(_service.GetById(id));

            return RedirectToAction(nameof(Index));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _service.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
