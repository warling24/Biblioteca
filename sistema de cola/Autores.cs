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
    public partial class Autores : Form
    {
        MySqlConnection josemaria = new MySqlConnection("Server=LocalHost;DataBase=Biblioteca;Uid=root;Pwd=12345678;");
        int idaut;
        public Autores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = dataGridView1.Rows.Count;
            josemaria.Open();
            string query = "Insert into Autores values (" + cod + ",@Nom_Autor,@Apel_Autor,@Nacionalidad);";
            MySqlCommand insert = new MySqlCommand(query, josemaria);
            insert.Parameters.AddWithValue("@Nom_Autor", txtNom.Text);
            insert.Parameters.AddWithValue("@Apel_Autor", txtApel.Text);
            insert.Parameters.AddWithValue("@Nacionalidad", txtNac.Text);
            insert.ExecuteNonQuery();
            josemaria.Close();

            MostrarTabla();
        }
        private void MostrarTabla()
        {
            josemaria.Open();
            MySqlCommand select = new MySqlCommand("Select * from autores;",josemaria);
            MySqlDataAdapter adp = new MySqlDataAdapter(select);
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            dataGridView1.DataSource = tabla;
            josemaria.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            josemaria.Open();
            string query = "Delete from Autores where Id_Aut = " + idaut +  ";";
            MySqlCommand delete = new MySqlCommand(query, josemaria);
            delete.ExecuteNonQuery();
            josemaria.Close();

            MostrarTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            josemaria.Open();
            string query = "Update Autores set Nom_Autor = @Nom_Autor,Apel_Autor = @Apel_Autor,Nacionalidad = @Nacionalidad where Id_Aut =" + idaut + ";";
            MySqlCommand Upd = new MySqlCommand(query, josemaria);
            Upd.Parameters.AddWithValue("@Nom_Autor", txtNom.Text);
            Upd.Parameters.AddWithValue("@Apel_Autor", txtApel.Text);
            Upd.Parameters.AddWithValue("@@Nacionalidad", txtNac.Text);
            Upd.ExecuteNonQuery();
            josemaria.Close();

            MostrarTabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idaut = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
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

        private void Autores_Load(object sender, EventArgs e)
        {
            LoadTheme();
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
        }
    }
}
