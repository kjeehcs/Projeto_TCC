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
                    // Exibir a imagem na PictureBox
                    btnfotoCadastro.ImageLocation = caminhoDaImagem;

                }
            }
            MessageBox.Show(caminhoDaImagem);

        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            
            UsuariosInfo usuario = new UsuariosInfo();
            usuario.login_usuario = txb_loginCadastro.Text;
            usuario.senha_usuario = txb_senhaCadastro.Text;
            usuario.nome_usuario = txb_nomeCadastro.Text;
            usuario.email_usuario = txb_emailCadastro.Text;
            usuario.imagem_data = caminhoDaImagem;
            usuario.nivel_usuario = comboBoxNivelUsuario.Text;
            //usuario.id_usuario = Convert.ToInt32(label5.Text);
            
            
            try
            {
                usuariosRepository.insert(usuario);
                MessageBox.Show("Registro Salvo!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
