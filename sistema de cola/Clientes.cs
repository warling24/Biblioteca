using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_de_cola
{
    public partial class Clientes : Form
    {
        MySqlConnection josemaria = new MySqlConnection("Server=LocalHost;DataBase=Biblioteca;Uid=root;Pwd=12345678");
        public Clientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            LoadTheme();
            MostrarTabla();
        }

        private void MostrarTabla()
        {
            josemaria.Open();
            MySqlCommand select = new MySqlCommand("Select * from Clientes;",josemaria);
            MySqlDataAdapter adp = new MySqlDataAdapter(select);
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            dataGridView1.DataSource = tabla;
            josemaria.Close();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Colores.colorPrimario;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Colores.colorSecundario;
                }
            }
            foreach (Control lbls in this.Controls)
            {
                if (lbls.GetType() == typeof(Label))
                {
                    Label lbl = (Label)lbls;

                    lbl.ForeColor = Colores.colorSecundario;

                }
            }
            
        }
    }
}
