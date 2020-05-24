using BDProjetoAplicacao;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            var appUsuario = new UsuarioAplicacao();
            var listaUsuario = appUsuario.ListarTodos();
            return View(listaUsuario);
        }
        public ActionResult Cadastrar()
        {
           
            return View();
        }
    }
}