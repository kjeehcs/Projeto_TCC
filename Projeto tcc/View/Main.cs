﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Projeto_tcc.Repository;
using Projeto_tcc.Model;
using Projeto_tcc.View;
using System.Reflection.Emit;

namespace Projeto_tcc
{
    public partial class Main : Form
    {
        private readonly UsuariosRepository usuariosRepository = new UsuariosRepository();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        private string login_usuario;

        public Main(string login)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.login_usuario = login;
            CarregarImagem();

        }
        private void CarregarImagem()
        {
            Usuarios usuario = new Usuarios();
            List<Usuarios> usuariosInfos = usuariosRepository.findAll();

            foreach (Usuarios user in usuariosInfos)
            {
                if (user.login_usuario == login_usuario)
                {
                    usuario = user;
                }
            }
            pictureMain.Image = System.Drawing.Image.FromFile(usuario.imagem_data);
            lblNomeMain.Text = usuario.nome_usuario;
            labelAdmin.Text = usuario.nivel_usuario;
        }
        private void main_Load(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new Inicio());
        }
        public void AbrirNOPrincipal(object form)
        {
            if (this.Principal.Controls.Count > 0)
                this.Principal.Controls.RemoveAt(0);
            Form principal = form as Form;
            principal.TopLevel = false;
            principal.FormBorderStyle = FormBorderStyle.None;
            principal.Dock = DockStyle.Fill;
            this.Principal.Controls.Add(principal);
            this.Principal.Tag = principal;
            principal.BringToFront();
            principal.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(45, 51, 73);
            AbrirNOPrincipal(new Dash());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new Listas());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new Inicio());
        }

        private void CarregarDadosUsuario()
        {
            Usuarios usuario = new Usuarios();
            List<Usuarios> usuariosInfos = usuariosRepository.findAll();

            foreach (Usuarios user in usuariosInfos)
            {
                if (user.login_usuario == login_usuario)
                {
                    usuario = user;
                }
            }

            pictureMain.Image = System.Drawing.Image.FromFile(usuario.imagem_data);

            lblNomeMain.Text = usuario.nome_usuario;
        }



        private void btnPerfil_Click(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(45, 51, 73);
            AbrirNOPrincipal(new Perfil(login_usuario));
            CarregarDadosUsuario();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new Cadastro());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
