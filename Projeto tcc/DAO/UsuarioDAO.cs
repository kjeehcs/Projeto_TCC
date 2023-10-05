using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projeto_tcc.DB;
using Projeto_tcc.Model;
using static Projeto_tcc.Program;

namespace Projeto_tcc.DAO
{
    public class UsuarioDAO
    {
        public bool tem = false;
        public string mensagem = "";
        public bool verificarUsuario(Usuario model)
        {
            using (NpgsqlConnection connection = ConnectionDB.Connection())
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM Usuarios WHERE login_usuario=@login_usuario AND senha_usuario=@senha_usuario";
                //command.CommandText = "SELECT * FROM Usuarios WHERE login_usuario='jef' AND senha_usuario='456'";

                command.Parameters.AddWithValue("@login_usuario", model.login_usuario);
                command.Parameters.AddWithValue("@senha_usuario", model.senha_usuario);

                using (NpgsqlDataReader dr = command.ExecuteReader())
                {
                    try
                    {
                        if (dr.HasRows)
                        {
                            return tem = true;
                        }
                    }
                    catch (Exception)
                    {
                        this.mensagem = "Erro com Banco de Dados!";
                    }
                    return tem;
                }
            }
        }


        public Usuario selectById(Usuario model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Usuario WHERE id_usuario=@id_usuario";

            command.Parameters.AddWithValue("@id_usuario", model.id_usuario);

            NpgsqlDataReader dr = ConnectionDB.Select(command);

            if (dr.HasRows)
            {
                dr.Read();
                model.id_usuario = (int)dr["id_usuario"];
                model.login_usuario = (string)dr["login_usuario"];
                model.senha_usuario = (string)dr["senha_usuario"];
            }

            return model;
        }
    }
}
