using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_tcc.DAO;
using Projeto_tcc.Model;

namespace Projeto_tcc.Model
{
    public class UsuariosInfo
    {
        public int id_usuario { get; set; }
        public string login_usuario { get; set; }
        public string senha_usuario { get; set; }
        public bool tem;
        public string mensagem = "";

        public UsuariosInfo()
        {
        }

        public bool VerificarUsuario()
        {
            UsuarioDAO dao = new UsuarioDAO();

            return dao.verificarUsuario(this);
        }


    }
}
