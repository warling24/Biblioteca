﻿
namespace sistema_de_cola
{
    partial class Devolver
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.tContra = new System.Windows.Forms.TextBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cliente";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Libro";
            this.label3.Visible = false;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(387, 172);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(74, 17);
            this.lblCon.TabIndex = 29;
            this.lblCon.Text = "Id cliente";
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu.Location = new System.Drawing.Point(211, 173);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(58, 17);
            this.lblUsu.TabIndex = 28;
            this.lblUsu.Text = "Id libro";
            // 
            // tContra
            // 
            this.tContra.Location = new System.Drawing.Point(463, 172);
            this.tContra.Name = "tContra";
            this.tContra.Size = new System.Drawing.Size(100, 20);
            this.tContra.TabIndex = 27;
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(272, 172);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(100, 20);
            this.tUsuario.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha de entrega";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(412, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 23);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // bInsert
            // 
            this.bInsert.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bInsert.FlatAppearance.BorderSize = 0;
            this.bInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(267, 253);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(241, 45);
            this.bInsert.TabIndex = 34;
            this.bInsert.Text = "Devolver";
            this.bInsert.UseVisualStyleBackColor = false;
            // 
            // Devolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.tContra);
            this.Controls.Add(this.tUsuario);
            this.Name = "Devolver";
            this.Text = "Devolver";
            this.Load += new System.EventHandler(this.Devolver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.TextBox tContra;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bInsert;
    }
}