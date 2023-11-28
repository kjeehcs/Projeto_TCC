using Projeto_tcc.Model;
using Projeto_tcc.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_tcc.View
{
    public partial class Cadastro : Form
    {
        private string caminhoDaImagem;
        private readonly UsuariosRepository usuariosRepository = new UsuariosRepository();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnfotoCadastro_Click(object sender, EventArgs e)
        {
            var caminhoFoto = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Todos os Arquivos|*.*";
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Title = "Escolher Imagem";

                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoDaImagem = openFileDialog.FileName;

                    btnfotoCadastro.ImageLocation = caminhoDaImagem;

                }

            }
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_loginCadastro.Text) ||
                string.IsNullOrWhiteSpace(txb_senhaCadastro.Text) ||
                string.IsNullOrWhiteSpace(txb_nomeCadastro.Text) ||
                string.IsNullOrWhiteSpace(txb_emailCadastro.Text) ||
                string.IsNullOrWhiteSpace(comboBoxNivelUsuario.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Verificar se o usuário já existe no banco de dados
                if (usuariosRepository.UserExists(txb_loginCadastro.Text, txb_senhaCadastro.Text))
                {
                    MessageBox.Show("Já existe um usuário com o mesmo login!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Usuarios usuario = new Usuarios();
                    usuario.login_usuario = txb_loginCadastro.Text;
                    usuario.senha_usuario = txb_senhaCadastro.Text;
                    usuario.nome_usuario = txb_nomeCadastro.Text;
                    usuario.email_usuario = txb_emailCadastro.Text;
                    usuario.nivel_usuario = comboBoxNivelUsuario.Text;

                    if (string.IsNullOrEmpty(caminhoDaImagem))
                    {
                        MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        usuario.imagem_data = caminhoDaImagem;

                        try
                        {
                            usuariosRepository.insert(usuario);
                            MessageBox.Show("Registro Salvo!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void picMostrar_Click(object sender, EventArgs e)
        {
            picOcultar.BringToFront();
            txb_senhaCadastro.PasswordChar = (txb_senhaCadastro.PasswordChar == '●') ? '\0' : '●';
        }

        private void picOcultar_Click(object sender, EventArgs e)
        {
            picMostrar.BringToFront();
            txb_senhaCadastro.PasswordChar = (txb_senhaCadastro.PasswordChar == '\0') ? '●' : txb_senhaCadastro.PasswordChar;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
