
namespace calculadora
{
    partial class form1
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
            this.dysplay = new System.Windows.Forms.TextBox();
            this.btnn7 = new System.Windows.Forms.Button();
            this.btnn4 = new System.Windows.Forms.Button();
            this.btnn1 = new System.Windows.Forms.Button();
            this.btnres = new System.Windows.Forms.Button();
            this.btnn8 = new System.Windows.Forms.Button();
            this.btnn9 = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnn6 = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnn2 = new System.Windows.Forms.Button();
            this.btnn5 = new System.Windows.Forms.Button();
            this.btnrealizar = new System.Windows.Forms.Button();
            this.btnn3 = new System.Windows.Forms.Button();
            this.btnn0 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dysplay
            // 
            this.dysplay.Enabled = false;
            this.dysplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dysplay.Location = new System.Drawing.Point(12, 28);
            this.dysplay.Name = "dysplay";
            this.dysplay.Size = new System.Drawing.Size(396, 53);
            this.dysplay.TabIndex = 0;
            this.dysplay.Text = "0";
            this.dysplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnn7
            // 
            this.btnn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn7.Location = new System.Drawing.Point(12, 110);
            this.btnn7.Name = "btnn7";
            this.btnn7.Size = new System.Drawing.Size(60, 60);
            this.btnn7.TabIndex = 1;
            this.btnn7.Text = "7";
            this.btnn7.UseVisualStyleBackColor = true;
            this.btnn7.Click += new System.EventHandler(this.btnn7_Click);
            // 
            // btnn4
            // 
            this.btnn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn4.Location = new System.Drawing.Point(12, 191);
            this.btnn4.Name = "btnn4";
            this.btnn4.Size = new System.Drawing.Size(60, 60);
            this.btnn4.TabIndex = 2;
            this.btnn4.Text = "4";
            this.btnn4.UseVisualStyleBackColor = true;
            this.btnn4.Click += new System.EventHandler(this.btnn4_Click);
            // 
            // btnn1
            // 
            this.btnn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn1.Location = new System.Drawing.Point(12, 269);
            this.btnn1.Name = "btnn1";
            this.btnn1.Size = new System.Drawing.Size(60, 60);
            this.btnn1.TabIndex = 3;
            this.btnn1.Text = "1";
            this.btnn1.UseVisualStyleBackColor = true;
            this.btnn1.Click += new System.EventHandler(this.btnn1_Click);
            // 
            // btnres
            // 
            this.btnres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnres.Location = new System.Drawing.Point(271, 269);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(60, 60);
            this.btnres.TabIndex = 4;
            this.btnres.Text = "-";
            this.btnres.UseVisualStyleBackColor = true;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // btnn8
            // 
            this.btnn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn8.Location = new System.Drawing.Point(97, 110);
            this.btnn8.Name = "btnn8";
            this.btnn8.Size = new System.Drawing.Size(60, 60);
            this.btnn8.TabIndex = 5;
            this.btnn8.Text = "8";
            this.btnn8.UseVisualStyleBackColor = true;
            this.btnn8.Click += new System.EventHandler(this.btnn8_Click);
            // 
            // btnn9
            // 
            this.btnn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn9.Location = new System.Drawing.Point(185, 110);
            this.btnn9.Name = "btnn9";
            this.btnn9.Size = new System.Drawing.Size(60, 60);
            this.btnn9.TabIndex = 6;
            this.btnn9.Text = "9";
            this.btnn9.UseVisualStyleBackColor = true;
            this.btnn9.Click += new System.EventHandler(this.btnn9_Click);
            // 
            // btnmul
            // 
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.Location = new System.Drawing.Point(271, 110);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(60, 60);
            this.btnmul.TabIndex = 7;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnn6
            // 
            this.btnn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn6.Location = new System.Drawing.Point(185, 191);
            this.btnn6.Name = "btnn6";
            this.btnn6.Size = new System.Drawing.Size(60, 60);
            this.btnn6.TabIndex = 8;
            this.btnn6.Text = "6";
            this.btnn6.UseVisualStyleBackColor = true;
            this.btnn6.Click += new System.EventHandler(this.btnn6_Click);
            // 
            // btndiv
            // 
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(271, 191);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(60, 60);
            this.btndiv.TabIndex = 9;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnn2
            // 
            this.btnn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn2.Location = new System.Drawing.Point(97, 269);
            this.btnn2.Name = "btnn2";
            this.btnn2.Size = new System.Drawing.Size(60, 60);
            this.btnn2.TabIndex = 10;
            this.btnn2.Text = "2";
            this.btnn2.UseVisualStyleBackColor = true;
            this.btnn2.Click += new System.EventHandler(this.btnn2_Click);
            // 
            // btnn5
            // 
            this.btnn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn5.Location = new System.Drawing.Point(97, 191);
            this.btnn5.Name = "btnn5";
            this.btnn5.Size = new System.Drawing.Size(60, 60);
            this.btnn5.TabIndex = 11;
            this.btnn5.Text = "5";
            this.btnn5.UseVisualStyleBackColor = true;
            this.btnn5.Click += new System.EventHandler(this.btnn5_Click);
            // 
            // btnrealizar
            // 
            this.btnrealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrealizar.Location = new System.Drawing.Point(12, 344);
            this.btnrealizar.Name = "btnrealizar";
            this.btnrealizar.Size = new System.Drawing.Size(60, 64);
            this.btnrealizar.TabIndex = 12;
            this.btnrealizar.Text = "=";
            this.btnrealizar.UseVisualStyleBackColor = true;
            this.btnrealizar.Click += new System.EventHandler(this.btnrealizar_Click);
            // 
            // btnn3
            // 
            this.btnn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn3.Location = new System.Drawing.Point(185, 269);
            this.btnn3.Name = "btnn3";
            this.btnn3.Size = new System.Drawing.Size(60, 60);
            this.btnn3.TabIndex = 13;
            this.btnn3.Text = "3";
            this.btnn3.UseVisualStyleBackColor = true;
            this.btnn3.Click += new System.EventHandler(this.btnn3_Click);
            // 
            // btnn0
            // 
            this.btnn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn0.Location = new System.Drawing.Point(97, 344);
            this.btnn0.Name = "btnn0";
            this.btnn0.Size = new System.Drawing.Size(60, 64);
            this.btnn0.TabIndex = 14;
            this.btnn0.Text = "0";
            this.btnn0.UseVisualStyleBackColor = true;
            this.btnn0.Click += new System.EventHandler(this.btnn0_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.Location = new System.Drawing.Point(185, 344);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(60, 64);
            this.btnpunto.TabIndex = 15;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btnmas
            // 
            this.btnmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmas.Location = new System.Drawing.Point(271, 344);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(60, 64);
            this.btnmas.TabIndex = 16;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(348, 110);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(60, 64);
            this.btnborrar.TabIndex = 17;
            this.btnborrar.Text = "C";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btnn0);
            this.Controls.Add(this.btnn3);
            this.Controls.Add(this.btnrealizar);
            this.Controls.Add(this.btnn5);
            this.Controls.Add(this.btnn2);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnn6);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnn9);
            this.Controls.Add(this.btnn8);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.btnn1);
            this.Controls.Add(this.btnn4);
            this.Controls.Add(this.btnn7);
            this.Controls.Add(this.dysplay);
            this.Name = "form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dysplay;
        private System.Windows.Forms.Button btnn7;
        private System.Windows.Forms.Button btnn4;
        private System.Windows.Forms.Button btnn1;
        private System.Windows.Forms.Button btnres;
        private System.Windows.Forms.Button btnn8;
        private System.Windows.Forms.Button btnn9;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btnn6;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnn2;
        private System.Windows.Forms.Button btnn5;
        private System.Windows.Forms.Button btnrealizar;
        private System.Windows.Forms.Button btnn3;
        private System.Windows.Forms.Button btnn0;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnborrar;
    }
}

