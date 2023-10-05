using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_tcc
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void switchTema_CheckedChanged(object sender, EventArgs e)
        {
            if (switchTema.Checked)
            {
                lbltema.Text = "Tema Escuro";
            }
            else
            {
                lbltema.Text = "Tema Claro";
            }
        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {
            materialTextBox21.ForeColor = Color.White;
        }

        public override System.Drawing.Color ForeColor { get; set; }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            materialTextBox1.ForeColor = Color.White;
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnfoto.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
