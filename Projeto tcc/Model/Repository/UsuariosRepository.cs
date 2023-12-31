﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Projeto_tcc.DB;
using Projeto_tcc.Model;
using NpgsqlTypes;

namespace Projeto_tcc.Repository
{
    public class UsuariosRepository : IUsuarios
    {
        public List<Usuarios> findAll()
        {
            using (NpgsqlConnection connection = ConnectionDB.Connection())
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM Usuarios";

                List<Usuarios> usuarios = new List<Usuarios>();
                NpgsqlDataReader dr = ConnectionDB.Select(command);
                while (dr.Read())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.id_usuario = (int)dr["id_usuario"];
                    usuario.login_usuario = (string)dr["login"];
                    usuario.senha_usuario = (string)dr["senha"];
                    usuario.nome_usuario = (string)dr["nome_usuario"];
                    usuario.email_usuario = (string)dr["email_usuario"];
                    usuario.nivel_usuario = (string)dr["nivel_usuario"];
                    usuario.imagem_data = (string)dr["imagem_data"];


                    usuarios.Add(usuario);
                }
                dr.Close();
                return usuarios;
            }
        }

        public void insert(Usuarios obj)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Usuarios (login, senha, nome_usuario, email_usuario, nivel_usuario, imagem_data) " +
                                               "VALUES (@login, @senha, @nome_usuario, @email_usuario, @nivel_usuario, @imagem_data)";

            command.Parameters.AddWithValue("@login", obj.login_usuario);
            command.Parameters.AddWithValue("@senha", obj.senha_usuario);
            command.Parameters.AddWithValue("@nome_usuario", obj.nome_usuario);
            command.Parameters.AddWithValue("@email_usuario", obj.email_usuario);
            command.Parameters.AddWithValue("@nivel_usuario", obj.nivel_usuario);
            command.Parameters.AddWithValue("@imagem_data", obj.imagem_data);


            ConnectionDB.CRUD(command);
        }

        public void update(Usuarios obj)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Usuarios SET login=@login,  senha=@senha, nome_usuario=@nome_usuario, email_usuario=@email_usuario, imagem_data=@imagem_data " +
                                                 "WHERE id_usuario=@id_usuario";

            command.Parameters.AddWithValue("@id_usuario", obj.id_usuario);
            command.Parameters.AddWithValue("@login", obj.login_usuario);
            command.Parameters.AddWithValue("@senha", obj.senha_usuario);
            command.Parameters.AddWithValue("@nome_usuario", obj.nome_usuario);
            command.Parameters.AddWithValue("@email_usuario", obj.email_usuario);
            command.Parameters.AddWithValue("@imagem_data", obj.imagem_data);

            ConnectionDB.CRUD(command);
        }


        public Usuarios findById(int id_usuario)
        {
            using (NpgsqlConnection connection = ConnectionDB.Connection())
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM Usuarios WHERE id_usuario = @id_usuario";

                command.Parameters.AddWithValue("@id_usuario", id_usuario);

                using (NpgsqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return new Usuarios
                        {
                            id_usuario = Convert.ToInt32(dr["id_usuario"]),
                            login_usuario = dr["login"].ToString(),
                            senha_usuario = dr["senha"].ToString(),
                            nome_usuario = dr["nome_usuario"].ToString(),
                            email_usuario = dr["email_usuario"].ToString(),
                            nivel_usuario = dr["nivel_usuario"].ToString(),
                            imagem_data = dr["imagem_data"].ToString(),
                        };
                    }
                    return null;
                }
            }
        }

        public bool UserExists(string login, string senha)
        {
            using (NpgsqlConnection connection = ConnectionDB.Connection())
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE login=@login AND senha=@senha";

                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@senha", senha);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }
    }
}

