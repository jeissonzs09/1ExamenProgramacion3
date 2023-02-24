namespace JeissonZelaya
{
    partial class Factura
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
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.Preciolabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductotextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DescuentotextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descuento";
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoLabel.Location = new System.Drawing.Point(46, 85);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(81, 20);
            this.ProductoLabel.TabIndex = 1;
            this.ProductoLabel.Text = "Producto";
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preciolabel.Location = new System.Drawing.Point(46, 124);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(59, 20);
            this.Preciolabel.TabIndex = 2;
            this.Preciolabel.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // ProductotextBox
            // 
            this.ProductotextBox.Location = new System.Drawing.Point(133, 85);
            this.ProductotextBox.Name = "ProductotextBox";
            this.ProductotextBox.Size = new System.Drawing.Size(215, 20);
            this.ProductotextBox.TabIndex = 4;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(133, 126);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(92, 20);
            this.PreciotextBox.TabIndex = 5;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(133, 160);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(92, 20);
            this.CantidadtextBox.TabIndex = 6;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.BackColor = System.Drawing.Color.Cyan;
            this.Calcularbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcularbutton.Location = new System.Drawing.Point(170, 268);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(90, 30);
            this.Calcularbutton.TabIndex = 7;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = false;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total a Pagar con Descuento Incluido 15%";
            // 
            // DescuentotextBox
            // 
            this.DescuentotextBox.Location = new System.Drawing.Point(246, 232);
            this.DescuentotextBox.Name = "DescuentotextBox";
            this.DescuentotextBox.Size = new System.Drawing.Size(92, 20);
            this.DescuentotextBox.TabIndex = 9;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.Color.Cyan;
            this.Nuevobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.Location = new System.Drawing.Point(278, 268);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(157, 30);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.Text = "Nuevo Producto";
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 377);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.DescuentotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.ProductotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Preciolabel);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.label1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductotextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescuentotextBox;
        private System.Windows.Forms.Button Nuevobutton;
    }
}