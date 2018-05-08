namespace MaquinaTuring
{
    partial class Form1
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
            this.btnRun = new System.Windows.Forms.Button();
            this.rdbPalindromas = new System.Windows.Forms.RadioButton();
            this.rdbCopia = new System.Windows.Forms.RadioButton();
            this.rdbSuma = new System.Windows.Forms.RadioButton();
            this.rdbResta = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.DGVCadena = new System.Windows.Forms.DataGridView();
            this.MaquinaTuring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCadena)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(186, 53);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rdbPalindromas
            // 
            this.rdbPalindromas.AutoSize = true;
            this.rdbPalindromas.Location = new System.Drawing.Point(12, 14);
            this.rdbPalindromas.Name = "rdbPalindromas";
            this.rdbPalindromas.Size = new System.Drawing.Size(107, 21);
            this.rdbPalindromas.TabIndex = 1;
            this.rdbPalindromas.TabStop = true;
            this.rdbPalindromas.Text = "Palindromas";
            this.rdbPalindromas.UseVisualStyleBackColor = true;
            // 
            // rdbCopia
            // 
            this.rdbCopia.AutoSize = true;
            this.rdbCopia.Location = new System.Drawing.Point(125, 14);
            this.rdbCopia.Name = "rdbCopia";
            this.rdbCopia.Size = new System.Drawing.Size(65, 21);
            this.rdbCopia.TabIndex = 2;
            this.rdbCopia.TabStop = true;
            this.rdbCopia.Text = "Copia";
            this.rdbCopia.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            this.rdbSuma.AutoSize = true;
            this.rdbSuma.Location = new System.Drawing.Point(196, 14);
            this.rdbSuma.Name = "rdbSuma";
            this.rdbSuma.Size = new System.Drawing.Size(65, 21);
            this.rdbSuma.TabIndex = 3;
            this.rdbSuma.TabStop = true;
            this.rdbSuma.Text = "Suma";
            this.rdbSuma.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            this.rdbResta.AutoSize = true;
            this.rdbResta.Location = new System.Drawing.Point(267, 14);
            this.rdbResta.Name = "rdbResta";
            this.rdbResta.Size = new System.Drawing.Size(66, 21);
            this.rdbResta.TabIndex = 4;
            this.rdbResta.TabStop = true;
            this.rdbResta.Text = "Resta";
            this.rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            this.rdbMultiplicacion.AutoSize = true;
            this.rdbMultiplicacion.Location = new System.Drawing.Point(339, 14);
            this.rdbMultiplicacion.Name = "rdbMultiplicacion";
            this.rdbMultiplicacion.Size = new System.Drawing.Size(113, 21);
            this.rdbMultiplicacion.TabIndex = 5;
            this.rdbMultiplicacion.TabStop = true;
            this.rdbMultiplicacion.Text = "Multiplicacion";
            this.rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(19, 85);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(541, 22);
            this.txtCadena.TabIndex = 6;
            // 
            // DGVCadena
            // 
            this.DGVCadena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCadena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaquinaTuring});
            this.DGVCadena.Location = new System.Drawing.Point(19, 132);
            this.DGVCadena.Name = "DGVCadena";
            this.DGVCadena.RowTemplate.Height = 24;
            this.DGVCadena.Size = new System.Drawing.Size(514, 467);
            this.DGVCadena.TabIndex = 7;
            // 
            // MaquinaTuring
            // 
            this.MaquinaTuring.HeaderText = "MaquinaTuring";
            this.MaquinaTuring.Name = "MaquinaTuring";
            this.MaquinaTuring.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 636);
            this.Controls.Add(this.DGVCadena);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.rdbMultiplicacion);
            this.Controls.Add(this.rdbResta);
            this.Controls.Add(this.rdbSuma);
            this.Controls.Add(this.rdbCopia);
            this.Controls.Add(this.rdbPalindromas);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCadena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RadioButton rdbPalindromas;
        private System.Windows.Forms.RadioButton rdbCopia;
        private System.Windows.Forms.RadioButton rdbSuma;
        private System.Windows.Forms.RadioButton rdbResta;
        private System.Windows.Forms.RadioButton rdbMultiplicacion;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.DataGridView DGVCadena;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaquinaTuring;
    }
}

