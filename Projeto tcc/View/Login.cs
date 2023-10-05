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
using Projeto_tcc.Controller;
using Projeto_tcc.Model;
using Projeto_tcc.Repository;
using Projeto_tcc.View;

namespace Projeto_tcc.View
{
    public partial class Login : Form
    {
        private UsuariosRepository usoRep = new UsuariosRepository();
        
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
        
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            btnEntrar.BackColor = Color.FromArgb(45, 51, 73);

            string login = Convert.ToString(txb_user_login.Text);
            string senha = Convert.ToString(txb_user_senha.Text);
            bool usuarioEncontrado = false;

            List<Usuario> usuarios = usoRep.findAll();



            foreach (Usuario uso in usuarios)
            {
                if (uso.login_usuario == login && uso.senha_usuario == senha)
                {
                    //MessageBox.Show(uso.id_usuario.ToString());
                    MessageBox.Show("Usuário encontrado");
                    Main profile = new Main();
                    this.Hide();
                    profile.Show();
                    usuarioEncontrado = true;
                    break;
                }
            }
            //MessageBox.Show(usuarioEncontrado.ToString());
            if (!usuarioEncontrado)
            {
                MessageBox.Show("Usuário não encontrado");
                login = Convert.ToString(txb_user_login.Text = "");
                senha = Convert.ToString(txb_user_senha.Text = "");
                txb_user_login.Focus();

            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
