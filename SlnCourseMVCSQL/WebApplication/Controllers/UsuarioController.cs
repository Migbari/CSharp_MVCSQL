using BDProjetoAplicacao;
using BDProjetoDominio;
using BDProjetoDominio.Interface;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Inicial()
        {
            var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAppADO();
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
                var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAppADO();
                appUsuario.Salvar(usuario);
                return RedirectToAction("Inicial");
            }
            return View(usuario);
        }
        public ActionResult Editar(string id)
        {
            var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAppADO();
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
                var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAppADO();
                appUsuario.Salvar(usuario);
                return RedirectToAction("Inicial");
            }
            return View(usuario);
        }
        public ActionResult Detalhes(string id)
        {
            var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAppADO();
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }
        public ActionResult Excluir(string id)
        {
            var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAppADO();
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }
        [HttpPost, ActionName ("Excluir")]
        public ActionResult ExcluirConfirmado(string id)
        {
            var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAppADO();
            var usuario = appUsuario.ListarPorId(id);
            appUsuario.Excluir(usuario);
            return RedirectToAction("Inicial");
        }
    }
}