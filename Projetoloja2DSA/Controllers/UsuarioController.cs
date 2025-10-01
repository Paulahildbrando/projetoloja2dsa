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
        //declara a variavel privada e somente leitura do tipo usuariorepositorio
        //instancia o _usuarioController para ser atribuido no construtor com os dados
        private readonly UsuarioRepositorio _usuarioRepositorio;

    //define o construtor da classe usuariocontroller
    //recebe a instancia de usuariorepositorio com parametros
}
    public UsuarioController(UsuarioRepositorio usuarioRepositorio)
    {
        //o construtor é chamado quando uma nova instancia é criada
        _usuarioRepositorio = usuarioRepositorio;
    }


    {
        //IRTEFACE QUE REPRESENTA O RESULTADO PA PÁGINA
        public IActionResult Index()
        {
            return View();
        }
    }
}
