﻿namespace Forms
{
    partial class AltaUniversidades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CodigoUniversidad = new System.Windows.Forms.TextBox();
            this.textBox_Siglo = new System.Windows.Forms.TextBox();
            this.textBox_Año = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_TipoUniversidad = new System.Windows.Forms.TextBox();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Universidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Universidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sigla:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Año en curso:";
            // 
            // textBox_CodigoUniversidad
            // 
            this.textBox_CodigoUniversidad.Location = new System.Drawing.Point(156, 24);
            this.textBox_CodigoUniversidad.Name = "textBox_CodigoUniversidad";
            this.textBox_CodigoUniversidad.Size = new System.Drawing.Size(389, 20);
            this.textBox_CodigoUniversidad.TabIndex = 5;
            // 
            // textBox_Siglo
            // 
            this.textBox_Siglo.Location = new System.Drawing.Point(156, 104);
            this.textBox_Siglo.Name = "textBox_Siglo";
            this.textBox_Siglo.Size = new System.Drawing.Size(389, 20);
            this.textBox_Siglo.TabIndex = 6;
            // 
            // textBox_Año
            // 
            this.textBox_Año.Location = new System.Drawing.Point(156, 135);
            this.textBox_Año.Name = "textBox_Año";
            this.textBox_Año.Size = new System.Drawing.Size(389, 20);
            this.textBox_Año.TabIndex = 7;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(156, 76);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(389, 20);
            this.textBox_Nombre.TabIndex = 8;
            // 
            // textBox_TipoUniversidad
            // 
            this.textBox_TipoUniversidad.Location = new System.Drawing.Point(156, 50);
            this.textBox_TipoUniversidad.Name = "textBox_TipoUniversidad";
            this.textBox_TipoUniversidad.Size = new System.Drawing.Size(389, 20);
            this.textBox_TipoUniversidad.TabIndex = 9;
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Location = new System.Drawing.Point(275, 165);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(142, 41);
            this.button_Confirmar.TabIndex = 10;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            // 
            // AltaUniversidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 213);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.textBox_TipoUniversidad);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_Año);
            this.Controls.Add(this.textBox_Siglo);
            this.Controls.Add(this.textBox_CodigoUniversidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaUniversidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CodigoUniversidad;
        private System.Windows.Forms.TextBox textBox_Siglo;
        private System.Windows.Forms.TextBox textBox_Año;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_TipoUniversidad;
        private System.Windows.Forms.Button button_Confirmar;
    }
}