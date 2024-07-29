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
    public partial class Login : Form
    {
        MySqlConnection josemaria = new MySqlConnection("Server=LocalHost;DataBase=Biblioteca;Uid=root;Pwd=12345678;");
        public Login()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                textBox1.ForeColor = Color.White;
                label4.Visible = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuario")
            {
                textBox1.Text = "";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "Contraseña";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Contraseña")
            {
                textBox3.Text = "";
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "Usuario";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void Login_Click(object sender, EventArgs e)
        {

                if (textBox1.Text == "")
                {
                    textBox1.Text = "Usuario";
                    textBox1.ForeColor = Color.Silver;
                    button1.Focus();
                }
                if (textBox3.Text == "")
                {
                    textBox3.Text = "Contraseña";
                    textBox3.ForeColor = Color.Silver;
                    button1.Focus();
                }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
                textBox3.ForeColor = Color.White;
            label5.Visible = false;
            textBox3.UseSystemPasswordChar = true;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                User.Usuario = textBox1.Text;
                User.Contraseña = textBox3.Text;
                if (User.validar())
                {
                    this.Hide();
                    Form sis = new Form1();
                    sis.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (!User.Vusu())
                    {
                        label4.Visible = true;
                    };
                    if (!User.Vcon())
                    {
                        label5.Visible = true;
                    };
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "Contraseña")
            {
                if (textBox3.UseSystemPasswordChar == false)
                {
                    textBox3.UseSystemPasswordChar = true;
                    button2.Image = sistema_de_cola.Properties.Resources.Blind_eye;
                }
                else
                {
                    textBox3.UseSystemPasswordChar = false;
                    button2.Image = sistema_de_cola.Properties.Resources.eye_3_24;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.Usuario = textBox1.Text;
            User.Contraseña = textBox3.Text;
            if (User.validar())
            {
                this.Hide();
                Form sis = new Form1();
                sis.ShowDialog();
                this.Close();
            }
            else 
            {
                if (!User.Vusu())
                {
                    label4.Visible = true;
                };
                if (!User.Vcon())
                {
                    label5.Visible = true;
                };
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form form = new Cuenta();
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
