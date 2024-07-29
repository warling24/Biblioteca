
namespace sistema_de_cola
{
    partial class Libros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTab = new System.Windows.Forms.Label();
            this.bUpd = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.lblTit = new System.Windows.Forms.Label();
            this.tTitulo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblAut = new System.Windows.Forms.Label();
            this.tAutor = new System.Windows.Forms.TextBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.nudPag = new System.Windows.Forms.NumericUpDown();
            this.lblPag = new System.Windows.Forms.Label();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.Location = new System.Drawing.Point(35, 15);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(47, 15);
            this.lblTab.TabIndex = 26;
            this.lblTab.Text = "Tabla ";
            // 
            // bUpd
            // 
            this.bUpd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bUpd.BackColor = System.Drawing.Color.Silver;
            this.bUpd.Enabled = false;
            this.bUpd.FlatAppearance.BorderSize = 0;
            this.bUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpd.Location = new System.Drawing.Point(559, 430);
            this.bUpd.Name = "bUpd";
            this.bUpd.Size = new System.Drawing.Size(90, 45);
            this.bUpd.TabIndex = 25;
            this.bUpd.Text = "Actualizar";
            this.bUpd.UseVisualStyleBackColor = false;
            this.bUpd.Click += new System.EventHandler(this.bUpd_Click);
            // 
            // bDel
            // 
            this.bDel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bDel.BackColor = System.Drawing.Color.Silver;
            this.bDel.Enabled = false;
            this.bDel.FlatAppearance.BorderSize = 0;
            this.bDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDel.Location = new System.Drawing.Point(446, 430);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(90, 45);
            this.bDel.TabIndex = 24;
            this.bDel.Text = "Eliminar";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.button2_Click);
            // 
            // bInsert
            // 
            this.bInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bInsert.BackColor = System.Drawing.Color.Silver;
            this.bInsert.FlatAppearance.BorderSize = 0;
            this.bInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(329, 430);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(90, 45);
            this.bInsert.TabIndex = 23;
            this.bInsert.Text = "Insertar";
            this.bInsert.UseVisualStyleBackColor = false;
            this.bInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTit
            // 
            this.lblTit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTit.AutoSize = true;
            this.lblTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.Location = new System.Drawing.Point(256, 371);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(49, 17);
            this.lblTit.TabIndex = 21;
            this.lblTit.Text = "Titulo";
            // 
            // tTitulo
            // 
            this.tTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tTitulo.Location = new System.Drawing.Point(306, 370);
            this.tTitulo.Name = "tTitulo";
            this.tTitulo.Size = new System.Drawing.Size(100, 20);
            this.tTitulo.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(910, 316);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblCant
            // 
            this.lblCant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(325, 397);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(72, 17);
            this.lblCant.TabIndex = 30;
            this.lblCant.Text = "Cantidad";
            // 
            // lblAut
            // 
            this.lblAut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAut.AutoSize = true;
            this.lblAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAut.Location = new System.Drawing.Point(525, 396);
            this.lblAut.Name = "lblAut";
            this.lblAut.Size = new System.Drawing.Size(47, 17);
            this.lblAut.TabIndex = 32;
            this.lblAut.Text = "Autor";
            // 
            // tAutor
            // 
            this.tAutor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tAutor.Location = new System.Drawing.Point(575, 396);
            this.tAutor.Name = "tAutor";
            this.tAutor.Size = new System.Drawing.Size(100, 20);
            this.tAutor.TabIndex = 31;
            // 
            // cmbCat
            // 
            this.cmbCat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Items.AddRange(new object[] {
            "Acción",
            "Romance",
            "Terror",
            "Comedia",
            "Psicológico",
            "Ciencia ficción"});
            this.cmbCat.Location = new System.Drawing.Point(417, 367);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(121, 24);
            this.cmbCat.TabIndex = 33;
            this.cmbCat.Text = "Categoria";
            this.cmbCat.SelectedIndexChanged += new System.EventHandler(this.cmbCat_SelectedIndexChanged);
            // 
            // nudPag
            // 
            this.nudPag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudPag.Location = new System.Drawing.Point(617, 370);
            this.nudPag.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPag.Name = "nudPag";
            this.nudPag.Size = new System.Drawing.Size(120, 20);
            this.nudPag.TabIndex = 34;
            this.nudPag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPag
            // 
            this.lblPag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPag.AutoSize = true;
            this.lblPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag.Location = new System.Drawing.Point(548, 370);
            this.lblPag.Name = "lblPag";
            this.lblPag.Size = new System.Drawing.Size(66, 17);
            this.lblPag.TabIndex = 29;
            this.lblPag.Text = "Paginas";
            // 
            // nudCant
            // 
            this.nudCant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudCant.Location = new System.Drawing.Point(398, 397);
            this.nudCant.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(120, 20);
            this.nudCant.TabIndex = 35;
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 502);
            this.Controls.Add(this.nudCant);
            this.Controls.Add(this.nudPag);
            this.Controls.Add(this.cmbCat);
            this.Controls.Add(this.lblAut);
            this.Controls.Add(this.tAutor);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblPag);
            this.Controls.Add(this.lblTab);
            this.Controls.Add(this.bUpd);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.lblTit);
            this.Controls.Add(this.tTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Libros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Button bUpd;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.TextBox tTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblAut;
        private System.Windows.Forms.TextBox tAutor;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.NumericUpDown nudPag;
        private System.Windows.Forms.Label lblPag;
        private System.Windows.Forms.NumericUpDown nudCant;
    }
}