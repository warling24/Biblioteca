
namespace sistema_de_cola
{
    partial class Autores
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
            this.label3 = new System.Windows.Forms.Label();
            this.bUpd = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tabla ";
            // 
            // bUpd
            // 
            this.bUpd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bUpd.Enabled = false;
            this.bUpd.FlatAppearance.BorderSize = 0;
            this.bUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpd.Location = new System.Drawing.Point(562, 400);
            this.bUpd.Name = "bUpd";
            this.bUpd.Size = new System.Drawing.Size(90, 45);
            this.bUpd.TabIndex = 25;
            this.bUpd.Text = "Actualizar";
            this.bUpd.UseVisualStyleBackColor = true;
            this.bUpd.Click += new System.EventHandler(this.button3_Click);
            // 
            // bDel
            // 
            this.bDel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bDel.Enabled = false;
            this.bDel.FlatAppearance.BorderSize = 0;
            this.bDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDel.Location = new System.Drawing.Point(449, 400);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(90, 45);
            this.bDel.TabIndex = 24;
            this.bDel.Text = "Eliminar";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.button2_Click);
            // 
            // bInsert
            // 
            this.bInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bInsert.FlatAppearance.BorderSize = 0;
            this.bInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(332, 400);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(90, 45);
            this.bInsert.TabIndex = 23;
            this.bInsert.Text = "Insertar";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // txtApel
            // 
            this.txtApel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtApel.Location = new System.Drawing.Point(466, 365);
            this.txtApel.Name = "txtApel";
            this.txtApel.Size = new System.Drawing.Size(100, 20);
            this.txtApel.TabIndex = 20;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNom.Location = new System.Drawing.Point(293, 365);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 19;
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
            this.dataGridView1.Size = new System.Drawing.Size(910, 312);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nacionalidad";
            // 
            // txtNac
            // 
            this.txtNac.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNac.Location = new System.Drawing.Point(676, 365);
            this.txtNac.Name = "txtNac";
            this.txtNac.Size = new System.Drawing.Size(100, 20);
            this.txtNac.TabIndex = 27;
            // 
            // Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 471);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bUpd);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Autores";
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.Autores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bUpd;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNac;
    }
}