using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_cola
{
    public partial class Form1 : Form
    {
        private Button botonactual;
        private Random random;
        private int indicetemp;
        public Form tempform;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private Color SelectThemeColor()
        {
            int indice = random.Next(Colores.ColorList.Count);
            while (indicetemp == indice)
            {
                indice = random.Next(Colores.ColorList.Count);
            }
            indicetemp = indice;
            string color = Colores.ColorList[indice];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                if (botonactual != (Button)btnSender)
                {

                    Color color = SelectThemeColor();
                    //Color color = ColorTranslator.FromHtml("#8BC240");
                    botonactual = (Button)btnSender;
                    botonactual.BackColor = color;
                    botonactual.ForeColor = Color.White;
                    botonactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel3.BackColor = color;
                    panel2.BackColor = Colores.ChangeColorBrightness(color, -0.3);
                    Colores.colorPrimario = color;
                    Colores.colorSecundario = Colores.ChangeColorBrightness(color, -0.3);
                    button6.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            //if (ActiveForm != null)
            //{
            //    ActiveForm.Close();
            //}
            ActivateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
            tempform = childForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Usuarios(),sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Clientes(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Libros(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Prestar(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Devolver(), sender);
        }
        private void Reset()
        {
            DisableButton();
            label1.Text = "Menú";
            panel3.BackColor = Color.FromArgb(0, 150, 136);
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            botonactual = null;
            button6.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //if (tempform != null)
            //{
            //    tempform.Close();
            //    Reset();
            //}
            panel4.Controls.Clear();
            Reset();

            Form form4 = new Menú();
            form4.TopLevel = false;
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(form4);
            this.panel4.Tag = form4;
            form4.Show();
            label1.Text = form4.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (User.Vnivel())
            {
                case 1:
                    button1.Visible = false;
                    button5.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button2.Location = new Point(0, 80);
                    break;
                case 2:
                    button1.Visible = false;
                    button5.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button2.Location = new Point(0, 137);
                    button5.Location = new Point(0, 80);
                    button3.Location = new Point(0, 196);
                    button4.Location = new Point(0, 256);
                    break;
                case 3:
                    button1.Visible = true;
                    button5.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Location = new Point(0, 137);
                    button3.Location = new Point(0, 256);
                    button4.Location = new Point(-3, 314);
                    button2.Location = new Point(0, 196);
                    break;
            }
            
            //Form login = new Login();
            Form form4 = new Menú();
            form4.TopLevel = false;
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(form4);
            this.panel4.Tag = form4;
            form4.BringToFront();
            form4.Show();
            label1.Text = form4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que quiere cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form form = new Login();
                form.ShowDialog();
                this.Close();
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel3_MouseDown(object sender, MouseEventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Autores(), sender);
        }
    }
}
