using BDProjetoAplicacao;
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
    }
}