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
    public partial class Libros : Form
    {
        MySqlConnection josemaria = new MySqlConnection("Server=LocalHost;DataBase=Biblioteca;Uid=root;Pwd=12345678");
        int indv;
        public Libros()
        {
            InitializeComponent();
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            MostrarTabla();
            LoadTheme();
        }

        public void MostrarTabla()
        {
            josemaria.Open();
            MySqlCommand select = new MySqlCommand("Select * from Libros;", josemaria);
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
            cmbCat.ForeColor = Colores.colorSecundario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = dataGridView1.Rows.Count;
            josemaria.Open();
            string query = "Insert into Libros values (" + cod + ",@Titulo,@Categoria,@Paginas,@Cantidad,@Autor);";
            MySqlCommand insert = new MySqlCommand(query, josemaria);
            insert.Parameters.AddWithValue("@Titulo", tTitulo.Text);
            insert.Parameters.AddWithValue("@Categoria", cmbCat.Text);
            insert.Parameters.AddWithValue("@Paginas", nudPag.Value);
            insert.Parameters.AddWithValue("@Cantidad", nudCant.Value);
            insert.Parameters.AddWithValue("@Autor", tAutor.Text);

            insert.ExecuteNonQuery();
            josemaria.Close();

            MostrarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            josemaria.Open();
            string query = "delete from Libros where id_Lib = " + indv + ";";
            MySqlCommand delete = new MySqlCommand(query, josemaria);
            delete.ExecuteNonQuery();
            josemaria.Close();

            MostrarTabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void bUpd_Click(object sender, EventArgs e)
        {
            josemaria.Open();
            string query = "update Libros set Titulo = @Titulo,Categoria = @Categoria,Paginas = @Paginas,Cantidad = @Cantidad,Autor = @Autor where id_Lib = '" + indv + "';";
            MySqlCommand update = new MySqlCommand(query, josemaria);
            update.Parameters.AddWithValue("@Titulo", tTitulo.Text);
            update.Parameters.AddWithValue("@Categoria", cmbCat.Text);
            update.Parameters.AddWithValue("@Paginas", nudPag.Value);
            update.Parameters.AddWithValue("@Cantidad", nudCant.Value);
            update.Parameters.AddWithValue("@Autor", tAutor.Text);
            update.ExecuteNonQuery();
            josemaria.Close();

            MostrarTabla();
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCat.Text != "Categoria")
            {
                cmbCat.ForeColor = Color.Black;
            }
        }
    }
}
