//IMPORTA AS BIBLIOTECAS QUE SERÃO UTILIZADAS NO PROJETO
using Microsoft.AspNetCore.Mvc;
using Projetoloja2DSA.Repositorio;

//DEFINE O NOME E ONDE A CLASSE USUARIOCONTROLLER ESTA LOCALIZADA
//NAMESPACE AJUDA A ORGANIZAR O CODIGO E EVITAR CONFLITOS
namespace Projetoloja2DSA.Controllers
{
    //CLASSE USUARIOCONTROLLER QUE ESTA HERDADNDO DA CLASSE PAI CONTROLLER
    public class UsuarioController : Controller
    {
        //declara a variavel privada e somente leitura do tipo UsuarioRepositorio
        //instancia o _usuarioController para ser atribuido no construtor com os dados
        private readonly UsuarioRepositorio _usuarioRepositorio;

        //define o construtor da classe UsuarioController
        //recebe a instancia de usuariorepositorio com parametros

        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            //o construtor é chamado quando uma nova instancia é criada
            _usuarioRepositorio = usuarioRepositorio;
        }
        
        [HttpGet]
        //INTERFACE É UMA REPRESENTAÇAO DO RESULTADO (TELA)
        public IActionResult Login()
        {
            //RETORNA A PAGINA INDEX
            return View();
        }

        [HttpPost]
                  //metodo login que recebe 2 parametros email e senha
        public IActionResult Login(string email, string senha)
        {
            // variavel usuario
            var usuario = _usuarioRepositorio.ObterUsuario(email);

            if (usuario != null && usuario.senha != senha)
            {
                return RedirectToAction("Index", "Cliente");
            }
            ModelState.AddModelError("", "Email / senha Inválidos");


            //RETORNA A PAGINA INDEX
            return View();
        }

        
    }
}