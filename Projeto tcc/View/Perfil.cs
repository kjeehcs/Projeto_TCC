using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_tcc.Model;

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


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    btnfoto.Image = new Bitmap(openFileDialog.FileName);

                }
            }

            /*
            OpenFileDialog openFileDialog = new OpenFileDialog();
            OpenFileDialog. = "Image files (*.png)";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                btnfoto.Image = new Bitmap(openFileDialog.FileName);
            }
            */
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {


            try
            {
                MemoryStream stream = new MemoryStream();
                btnfoto.BackgroundImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arrImage = stream.GetBuffer();

                //Chamar função para gravar/atualizar no banco
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
