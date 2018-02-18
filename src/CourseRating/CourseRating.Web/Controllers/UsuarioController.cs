using CourseRating.Application.Interface;
using CourseRating.Web.Mapper;
using CourseRating.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CourseRating.Web.Controllers
{
    public class UsuarioController :Controller
    {
        private readonly IUsuarioAppService usuarioApp;

        public UsuarioController(IUsuarioAppService usuariolApp)
        {
            this.usuarioApp = usuariolApp;
        }

        // GET: Usuario
        public ActionResult Index()
        {
            var allUsuarios = usuarioApp.GetAll().ToList();
            var usuarioViewModel = new List<UsuarioViewModel>();

            for (int i = 0; i < allUsuarios.Count; i++)
            {
                usuarioViewModel.Add(UsuarioMapper.BuildViewModelFrom(allUsuarios[i]));
            }

            return View(usuarioViewModel);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var usuario = usuarioApp.GetById(id.Value);
            var usuarioViewModel = UsuarioMapper.BuildViewModelFrom(usuario);

            if (usuario == null)
            {
                return HttpNotFound();
            }

            return View(usuarioViewModel);
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
        public ActionResult Create([Bind(Include = "Descricao,Status")] UsuarioViewModel usuarioViewModel)
        {
            if (ModelState.IsValid)
            {
                var usuario = UsuarioMapper.ExtractFromViewModel(usuarioViewModel);
                usuarioApp.Add(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioViewModel);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var usuarioViewModel = UsuarioMapper.BuildViewModelFrom(usuarioApp.GetById(id.Value));

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
        public ActionResult Edit([Bind(Include = "Descricao,Status,ReferenceId")] UsuarioViewModel usuarioViewModel)
        {
            if (ModelState.IsValid)
            {
                var usuario = UsuarioMapper.ExtractFromViewModel(usuarioViewModel);
                usuarioApp.Update(usuario);

                return RedirectToAction(nameof(Index));
            }
            return View(usuarioViewModel);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var usuario = usuarioApp.GetById(id.Value);

            var usuarioViewModel = UsuarioMapper.BuildViewModelFrom(usuario);

            if (usuarioViewModel == null)
            {
                return HttpNotFound();
            }

            return View(usuarioViewModel);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName(nameof(Delete))]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            usuarioApp.Remove(usuarioApp.GetById(id));
            return RedirectToAction(nameof(Index));
        }
    }
}