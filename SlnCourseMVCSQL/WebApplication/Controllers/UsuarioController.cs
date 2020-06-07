﻿using BDProjetoAplicacao;
using BDProjetoDominio;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Inicial()
        {
            var appUsuario = new UsuarioAplicacao();
            var listaUsuario = appUsuario.ListarTodos();
            return View(listaUsuario);
        }
        public ActionResult Cadastro()
        {
            return View();
        }
       [HttpPost]
       public ActionResult Cadastro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var appUsuario = new UsuarioAplicacao();
                appUsuario.Salvar(usuario);
                return RedirectToAction("Inicial");
            }
            return View(usuario);
        }
        public ActionResult Editar(int id)
        {
            var appUsuario = new UsuarioAplicacao();
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var appUsuario = new UsuarioAplicacao();
                appUsuario.Salvar(usuario);
                return RedirectToAction("Inicial");
            }
            return View(usuario);
        }
    }
}