using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CourseRating.Application.Interface;
using CourseRating.Data.Context;
using CourseRating.Domain.Interfaces.Services;
using CourseRating.Domain.Services;
using CourseRating.Web.ViewModels;

namespace CourseRating.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioAppService service;

        public UsuarioController(IUsuarioAppService usuarioApp)
        {
            service = usuarioApp;
        }

        //// GET: Usuario
        //public ActionResult Index()
        //{
        //    return View(db.UsuarioViewModels.ToList());
        //}

        //// GET: Usuario/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    UsuarioViewModel usuarioViewModel = db.UsuarioViewModels.Find(id);
        //    if (usuarioViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(usuarioViewModel);
        //}

        //// GET: Usuario/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Usuario/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Login,Senha,TipoUsuario")] UsuarioViewModel usuarioViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.UsuarioViewModels.Add(usuarioViewModel);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(usuarioViewModel);
        //}

        //// GET: Usuario/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    UsuarioViewModel usuarioViewModel = db.UsuarioViewModels.Find(id);
        //    if (usuarioViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(usuarioViewModel);
        //}

        //// POST: Usuario/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Login,Senha,TipoUsuario")] UsuarioViewModel usuarioViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(usuarioViewModel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(usuarioViewModel);
        //}

        //// GET: Usuario/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    UsuarioViewModel usuarioViewModel = db.UsuarioViewModels.Find(id);
        //    if (usuarioViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(usuarioViewModel);
        //}

        //// POST: Usuario/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    UsuarioViewModel usuarioViewModel = db.UsuarioViewModels.Find(id);
        //    db.UsuarioViewModels.Remove(usuarioViewModel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
