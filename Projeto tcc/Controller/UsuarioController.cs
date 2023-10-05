using Projeto_tcc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_tcc.Controller
{
    public class UsuarioController
    {
        public bool tem;
        public string mensagem = "";

        public bool verificarUsuario(string login_usuario, string senha_usuario)
        {
            Usuario model = new Usuario();

            model.login_usuario = login_usuario;
            model.senha_usuario = senha_usuario;

            model.VerificarUsuario();   
            return model.VerificarUsuario();
        }
    }
}
