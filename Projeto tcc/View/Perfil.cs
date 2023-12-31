﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using Projeto_tcc.DB;
using Projeto_tcc.Model;
using Projeto_tcc.Repository;
using Projeto_tcc.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Projeto_tcc
{
    public partial class Perfil : Form
    {
        private string login_usuario;
        private string caminhoDaImagem;
        private readonly UsuariosRepository usuariosRepository = new UsuariosRepository();
        public Perfil()
        {
            InitializeComponent();
          
        }
        public Perfil(string login) : this()
        {
            this.login_usuario = login;
            CarregarDadosUsuario();
        }

        private void CarregarDadosUsuario()
        {
            
            txb_login.Enabled = false;
            txb_senha.Enabled = false;
            txb_nome.Enabled = false;
            txb_email.Enabled = false;
            txbNivelUsuario.Enabled = false;
            btnfoto.Enabled = false;


            Usuarios usuario = new Usuarios();
            List<Usuarios> usuariosInfos = usuariosRepository.findAll();

            foreach (Usuarios user in usuariosInfos)
            {
                if (user.login_usuario == login_usuario)
                {
                    usuario = user;
                }
            }

            if (usuario.nivel_usuario == "Admin")
            {
                btnCadastrar.Visible = true;
            }
            btnfoto.Image = System.Drawing.Image.FromFile(usuario.imagem_data);


            if (usuario.login_usuario == null)
            {
                MessageBox.Show("Usuário não encontrado!");
            }
            else
            {
                if (usuario != null)
                {
                    label5.Text = Convert.ToString(usuario.id_usuario);
                    txb_login.Text = usuario.login_usuario;
                    txb_senha.Text = usuario.senha_usuario;
                    txb_nome.Text = usuario.nome_usuario;
                    txb_email.Text = usuario.email_usuario;
                    txbNivelUsuario.Text = usuario.nivel_usuario;
                }
                else
                {
                    MessageBox.Show("Dados do usuário não disponíveis!");
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void switchTema_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {
            txb_nome.ForeColor = Color.White;
        }

        public override System.Drawing.Color ForeColor { get; set; }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfoto_Click(object sender, EventArgs e)
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
                    btnfoto.ImageLocation = caminhoDaImagem;

                }
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            Usuarios usuario = new Usuarios();
            usuario.login_usuario = txb_login.Text;
            usuario.senha_usuario = txb_senha.Text;
            usuario.nome_usuario = txb_nome.Text;
            usuario.email_usuario = txb_email.Text;
            usuario.imagem_data = caminhoDaImagem;
            usuario.id_usuario = Convert.ToInt32(label5.Text);


            if (string.IsNullOrEmpty(usuario.imagem_data))
            {
                Usuarios usuarioExistente = usuariosRepository.findById(usuario.id_usuario);

                if (usuarioExistente != null)
                {
                    usuario.imagem_data = usuarioExistente.imagem_data;
                }
            }

            try
            {
                usuariosRepository.update(usuario);
                MessageBox.Show("Dados atualizados!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exibir_Click(object sender, EventArgs e)
        {
            CarregarDadosUsuario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txb_login.Enabled = true;
            txb_senha.Enabled = true;
            txb_nome.Enabled = true;
            txb_email.Enabled = true;
            btnfoto.Enabled = true;

        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picOcultar_Click(object sender, EventArgs e)
        {
            picMostrar.BringToFront();
            txb_senha.PasswordChar = (txb_senha.PasswordChar == '\0') ? '●' : txb_senha.PasswordChar;
        }

        private void picMostrar_Click(object sender, EventArgs e)
        {
            picOcultar.BringToFront();
            txb_senha.PasswordChar = (txb_senha.PasswordChar == '●') ? '\0' : '●';
        }
    }
}
