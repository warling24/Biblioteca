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
    public partial class Cuenta : Form
    {
        MySqlConnection josemaria = new MySqlConnection("Server=LocalHost;DataBase=Biblioteca;Uid=root;Pwd=12345678;");
        public Cuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.Usuario = textBox1.Text;
            User.Contraseña = textBox2.Text;
            if (textBox1.Text == "Usuario")
            {
                label4.Visible = true;
            }
            if (textBox2.Text == "Contraseña")
            {
                label2.Visible = true;
            }
            if ( textBox1.Text == "Usuario" | textBox2.Text == "Contraseña")
            {
                return;
            }
            else if (User.Vusu())
            {
                MessageBox.Show("El usuario ya existe.");
            }
            else
            {
                josemaria.Open();
                string query = "Insert into usuarios values (null,@Usuario,@Contraseña,1);";
                MySqlCommand insert = new MySqlCommand(query, josemaria);
                insert.Parameters.AddWithValue("@Usuario", textBox1.Text);
                insert.Parameters.AddWithValue("@Contraseña", textBox2.Text);
                insert.ExecuteNonQuery();
                josemaria.Close();

                MessageBox.Show("Cuenta creada correctamente, por favor inicie sesión.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
            label4.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.White;
            label2.Visible = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuario")
            {
                textBox1.Text = "";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Contraseña";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Contraseña")
            {
                textBox2.Text = "";
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "Usuario";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void Cuenta_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Usuario";
                textBox1.ForeColor = Color.Silver;
                button1.Focus();
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Contraseña";
                textBox2.ForeColor = Color.Silver;
                button1.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Login();
            form.ShowDialog();
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
