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
    public partial class Usuarios : Form
    {
        MySqlConnection josemaria = new MySqlConnection("Server=LocalHost;DataBase=Biblioteca;Uid=root;Pwd=12345678");
        int indv;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MostrarTabla();
            LoadTheme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = dataGridView1.Rows.Count;
                josemaria.Open();
                string query = "Insert into usuarios values (" + cod + ",@Usuario,@Contraseña,@Nivel);";
                MySqlCommand insert = new MySqlCommand(query, josemaria);
                insert.Parameters.AddWithValue("@Usuario", tUsuario.Text);
                insert.Parameters.AddWithValue("@Contraseña", tContra.Text);
                insert.Parameters.AddWithValue("Nivel", tNivel.Text);
                insert.ExecuteNonQuery();
                josemaria.Close();

                MostrarTabla();
        }
        public void MostrarTabla()
        {
            josemaria.Open();
            MySqlCommand select = new MySqlCommand("Select * from usuarios;", josemaria);
            MySqlDataAdapter adp = new MySqlDataAdapter(select);
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            dataGridView1.DataSource = tabla;
            josemaria.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            josemaria.Open();
            string query = "delete from Usuarios where id_Usu = " + indv + ";";
            MySqlCommand delete = new MySqlCommand(query,josemaria);
            delete.ExecuteNonQuery();
            josemaria.Close();

            MostrarTabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //indv = dataGridView1.CurrentRow.Index + 1;
            try
            {
                indv = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                bDel.Enabled = true;
                bUpd.Enabled = true;
            }
            catch
            {
                bDel.Enabled = false;
                bUpd.Enabled = false;
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            josemaria.Open();
            string query = "update Usuarios set Usuario = @Usuario,Contraseña = @Contraseña,Nivel = @Nivel where id_Usu = '" + indv + "';";
            MySqlCommand update = new MySqlCommand(query, josemaria);
            update.Parameters.AddWithValue("@Usuario", tUsuario.Text);
            update.Parameters.AddWithValue("@Contraseña", tContra.Text);
            update.Parameters.AddWithValue("Nivel", tNivel.Text);
            update.ExecuteNonQuery();
            josemaria.Close();

            MostrarTabla();
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
            //lblUsu.ForeColor = Colores.colorSecundario;
            //lblCon.ForeColor = Colores.colorSecundario;
            //lblNiv.ForeColor = Colores.colorSecundario;
            //lblTab.ForeColor = Colores.colorSecundario;
        }
    }
}
