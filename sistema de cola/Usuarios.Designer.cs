
namespace sistema_de_cola
{
    partial class Usuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tContra = new System.Windows.Forms.TextBox();
            this.lblUsu = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.bInsert = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bUpd = new System.Windows.Forms.Button();
            this.lblTab = new System.Windows.Forms.Label();
            this.lblNiv = new System.Windows.Forms.Label();
            this.tNivel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(498, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tUsuario
            // 
            this.tUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tUsuario.Location = new System.Drawing.Point(90, 365);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(100, 20);
            this.tUsuario.TabIndex = 1;
            // 
            // tContra
            // 
            this.tContra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tContra.Location = new System.Drawing.Point(288, 365);
            this.tContra.Name = "tContra";
            this.tContra.Size = new System.Drawing.Size(100, 20);
            this.tContra.TabIndex = 2;
            // 
            // lblUsu
            // 
            this.lblUsu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUsu.AutoSize = true;
            this.lblUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu.Location = new System.Drawing.Point(25, 365);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(64, 17);
            this.lblUsu.TabIndex = 3;
            this.lblUsu.Text = "Usuario";
            // 
            // lblCon
            // 
            this.lblCon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(196, 365);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(91, 17);
            this.lblCon.TabIndex = 4;
            this.lblCon.Text = "Contraseña";
            // 
            // bInsert
            // 
            this.bInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bInsert.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bInsert.FlatAppearance.BorderSize = 0;
            this.bInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(119, 400);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(90, 45);
            this.bInsert.TabIndex = 5;
            this.bInsert.Text = "Insertar";
            this.bInsert.UseVisualStyleBackColor = false;
            this.bInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDel
            // 
            this.bDel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bDel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bDel.Enabled = false;
            this.bDel.FlatAppearance.BorderSize = 0;
            this.bDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDel.Location = new System.Drawing.Point(232, 400);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(90, 45);
            this.bDel.TabIndex = 6;
            this.bDel.Text = "Eliminar";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.button2_Click);
            // 
            // bUpd
            // 
            this.bUpd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bUpd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bUpd.Enabled = false;
            this.bUpd.FlatAppearance.BorderSize = 0;
            this.bUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpd.Location = new System.Drawing.Point(345, 400);
            this.bUpd.Name = "bUpd";
            this.bUpd.Size = new System.Drawing.Size(90, 45);
            this.bUpd.TabIndex = 7;
            this.bUpd.Text = "Actualizar";
            this.bUpd.UseVisualStyleBackColor = false;
            this.bUpd.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.Location = new System.Drawing.Point(30, 14);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(47, 15);
            this.lblTab.TabIndex = 8;
            this.lblTab.Text = "Tabla ";
            // 
            // lblNiv
            // 
            this.lblNiv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNiv.AutoSize = true;
            this.lblNiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiv.Location = new System.Drawing.Point(394, 365);
            this.lblNiv.Name = "lblNiv";
            this.lblNiv.Size = new System.Drawing.Size(44, 17);
            this.lblNiv.TabIndex = 10;
            this.lblNiv.Text = "Nivel";
            // 
            // tNivel
            // 
            this.tNivel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tNivel.Location = new System.Drawing.Point(441, 365);
            this.tNivel.Name = "tNivel";
            this.tNivel.Size = new System.Drawing.Size(100, 20);
            this.tNivel.TabIndex = 9;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 471);
            this.Controls.Add(this.lblNiv);
            this.Controls.Add(this.tNivel);
            this.Controls.Add(this.lblTab);
            this.Controls.Add(this.bUpd);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.tContra);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tContra;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bUpd;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Label lblNiv;
        private System.Windows.Forms.TextBox tNivel;
    }
}