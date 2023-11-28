using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Projeto_tcc.Model;
using Projeto_tcc.Repository;
using Projeto_tcc.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Npgsql.Internal.TypeHandlers.LTreeHandlers;
using System.Net.Http;

namespace Projeto_tcc.View
{
    public partial class Login : Form
    {
        private UsuariosRepository usoRep = new UsuariosRepository();

        string apiToken = "0f1c0a417cb4a3c4648d38f67d4ff43346ce6ebb0e1ce54e61193808fb236ca3";
        string apiUrl = "http://172.20.10.9/admin/api.php"; 
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
        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            btnEntrar.BackColor = Color.FromArgb(45, 51, 73);


            string login = Convert.ToString(txb_user_login.Text);
            string senha = Convert.ToString(txb_user_senha.Text);

            bool usuarioEncontrado = false;

            List<Usuarios> usuarios = usoRep.findAll();

            foreach (Usuarios uso in usuarios)
            {
                if (uso.login_usuario == login && uso.senha_usuario == senha)
                {
                    MessageBox.Show("Bem vindo!!!");
                    this.Hide();
                    Main main = new Main(login);
                    main.Show();
                    usuarioEncontrado = true;
                    Cadastro cadastro = new Cadastro();
                    break;
                }
            }
            if (!usuarioEncontrado)
            {
                MessageBox.Show("Login ou Senha incorretos. Por favor, tente novamente.");
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

        private void picMostrar_Click(object sender, EventArgs e)
        {
            picOcultar.BringToFront();
            txb_user_senha.PasswordChar = (txb_user_senha.PasswordChar == '●') ? '\0' : '●';
        }

        private void picOcultar_Click(object sender, EventArgs e)
        {
            picMostrar.BringToFront();
            txb_user_senha.PasswordChar = (txb_user_senha.PasswordChar == '\0') ? '●' : txb_user_senha.PasswordChar;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
