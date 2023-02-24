namespace JeissonZelaya
{
    partial class Numeros_Multiplos
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
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.NumeroslistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.BackColor = System.Drawing.Color.PeachPuff;
            this.Calcularbutton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcularbutton.Location = new System.Drawing.Point(149, 130);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(125, 45);
            this.Calcularbutton.TabIndex = 0;
            this.Calcularbutton.Text = "Mostrar Números";
            this.Calcularbutton.UseVisualStyleBackColor = false;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // NumeroslistBox
            // 
            this.NumeroslistBox.FormattingEnabled = true;
            this.NumeroslistBox.Location = new System.Drawing.Point(460, 11);
            this.NumeroslistBox.Name = "NumeroslistBox";
            this.NumeroslistBox.Size = new System.Drawing.Size(128, 407);
            this.NumeroslistBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Presione el Botón para Mostrar los Números del 1 al 100";
            // 
            // Numeros_Multiplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeroslistBox);
            this.Controls.Add(this.Calcularbutton);
            this.Name = "Numeros_Multiplos";
            this.Text = "Numeros_Multiplos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.ListBox NumeroslistBox;
        private System.Windows.Forms.Label label1;
    }
}