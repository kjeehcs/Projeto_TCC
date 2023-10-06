using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Projeto_tcc.DB;
using Projeto_tcc.Model;

namespace Projeto_tcc.Repository
{
    public class UsuariosRepository
    {
        public List<UsuariosInfo> findAll()
        {

            using (NpgsqlConnection connection = ConnectionDB.Connection())
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM Usuarios";
                //command.CommandText = "SELECT * FROM Usuarios WHERE login_usuario='jef' AND senha_usuario='456'";

                List<UsuariosInfo> usuarios = new List<UsuariosInfo>();
                NpgsqlDataReader dr = ConnectionDB.Select(command);
                while (dr.Read())
                {
                    UsuariosInfo usuario = new UsuariosInfo();
                    usuario.id_usuario = (int)dr["id_usuario"];
                    usuario.login_usuario = (string)dr["login"];
                    usuario.senha_usuario = (string)dr["senha"];

                    usuarios.Add(usuario);
                }
                dr.Close();
                return usuarios;
            }
        }
    }
}
