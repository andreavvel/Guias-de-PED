namespace Ejemplo4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtespaciado = new System.Windows.Forms.TextBox();
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.btndibujar = new System.Windows.Forms.Button();
            this.areadibujo = new System.Windows.Forms.PictureBox();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txty1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txty2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espaciado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(97, 39);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(133, 20);
            this.txtcantidad.TabIndex = 3;
            // 
            // txtespaciado
            // 
            this.txtespaciado.Location = new System.Drawing.Point(97, 90);
            this.txtespaciado.Name = "txtespaciado";
            this.txtespaciado.Size = new System.Drawing.Size(133, 20);
            this.txtespaciado.TabIndex = 4;
            // 
            // cmbcolor
            // 
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Negro"});
            this.cmbcolor.Location = new System.Drawing.Point(88, 323);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(132, 21);
            this.cmbcolor.TabIndex = 5;
            // 
            // btndibujar
            // 
            this.btndibujar.Location = new System.Drawing.Point(48, 376);
            this.btndibujar.Name = "btndibujar";
            this.btndibujar.Size = new System.Drawing.Size(158, 37);
            this.btndibujar.TabIndex = 6;
            this.btndibujar.Text = "Dibujar líneas";
            this.btndibujar.UseVisualStyleBackColor = true;
            this.btndibujar.Click += new System.EventHandler(this.btndibujar_Click);
            // 
            // areadibujo
            // 
            this.areadibujo.Location = new System.Drawing.Point(258, 12);
            this.areadibujo.Name = "areadibujo";
            this.areadibujo.Size = new System.Drawing.Size(377, 424);
            this.areadibujo.TabIndex = 7;
            this.areadibujo.TabStop = false;
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(97, 190);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(133, 20);
            this.txtx2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor inicial de x2:";
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(97, 141);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(133, 20);
            this.txtx1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor inicial de x1:";
            // 
            // txty1
            // 
            this.txty1.Location = new System.Drawing.Point(97, 232);
            this.txty1.Name = "txty1";
            this.txty1.Size = new System.Drawing.Size(133, 20);
            this.txty1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor inicial de y1:";
            // 
            // txty2
            // 
            this.txty2.Location = new System.Drawing.Point(97, 281);
            this.txty2.Name = "txty2";
            this.txty2.Size = new System.Drawing.Size(133, 20);
            this.txty2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor inicial de y2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.txty1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txty2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.areadibujo);
            this.Controls.Add(this.btndibujar);
            this.Controls.Add(this.cmbcolor);
            this.Controls.Add(this.txtespaciado);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtespaciado;
        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.Button btndibujar;
        private System.Windows.Forms.PictureBox areadibujo;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txty1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txty2;
        private System.Windows.Forms.Label label7;
    }
}

