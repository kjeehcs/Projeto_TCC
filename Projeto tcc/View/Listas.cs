using Npgsql;
using Projeto_tcc.DB;
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
    public partial class Listas : Form
    {
        public Listas()
        {
            InitializeComponent();
            ExibirDataGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Listas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ExibirDataGrid()
        {
            NpgsqlCommand con = new NpgsqlCommand();
            con.Connection = ConnectionDB.Connection();
            con.CommandType = CommandType.Text;
            con.CommandText = "SELECT * FROM BlackList ORDER BY id_usuario";
            NpgsqlDataReader dr = con.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridBlackList.DataSource = dt;
            }
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
