using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_tcc.Model
{
    public class PerfilModel
    {
        private void SalvarDadosUsuario(string imagemPath)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("sua_string_de_conexao"))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        // Exemplo de comando SQL para inserir dados na tabela
                        command.CommandText = "INSERT INTO user_info (nome, email, imagem_data) VALUES (@nome, @email, @imagem_data) RETURNING id_usuario";

                        // Parâmetros
                        command.Parameters.AddWithValue("@nome", "Nome do Usuário");
                        command.Parameters.AddWithValue("@email", "email@example.com");

                        // Converta a imagem para bytes para armazenamento no banco de dados
                        byte[] imagemBytes = File.ReadAllBytes(imagemPath);
                        command.Parameters.AddWithValue("@imagem_data", imagemBytes);

                        // Execute o comando e obtenha o ID do usuário inserido
                        int idUsuario = (int)command.ExecuteScalar();

                        // Faça algo com o ID do usuário, se necessário
                        MessageBox.Show($"Usuário inserido com ID: {idUsuario}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar dados do usuário: {ex.Message}");
            }
        }
    }
}
