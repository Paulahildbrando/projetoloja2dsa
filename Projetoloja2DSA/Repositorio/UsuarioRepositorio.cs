using MySql.Data.MySqlClient;
using Projetoloja2DSA.Models;
namespace Projetoloja2DSA.Repositorio
{
    public class UsuarioRepositorio(IConfiguration configuration)
    {
        // Declara um campo privado somente leitura para armazenar a string de conexão com o MySQL.
        private readonly string _conexaoMySQL = configuration.GetConnectionString("ConexaoMySQL");


        public Usuario ObterUsuario(string email)
        {
           
        }
    }
}
     