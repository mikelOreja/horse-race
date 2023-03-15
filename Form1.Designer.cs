namespace carrera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.empezar = new System.Windows.Forms.Button();
            this.reiniciar = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Label();
            this.c3 = new System.Windows.Forms.Label();
            this.c4 = new System.Windows.Forms.Label();
            this.resul = new System.Windows.Forms.Label();
            this.progCab1 = new System.Windows.Forms.ProgressBar();
            this.progCab2 = new System.Windows.Forms.ProgressBar();
            this.progCab3 = new System.Windows.Forms.ProgressBar();
            this.progCab4 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // empezar
            // 
            this.empezar.Location = new System.Drawing.Point(29, 22);
            this.empezar.Name = "empezar";
            this.empezar.Size = new System.Drawing.Size(94, 29);
            this.empezar.TabIndex = 0;
            this.empezar.Text = "Empezar";
            this.empezar.UseVisualStyleBackColor = true;
            this.empezar.Click += new System.EventHandler(this.empezar_Click);
            // 
            // reiniciar
            // 
            this.reiniciar.Location = new System.Drawing.Point(145, 22);
            this.reiniciar.Name = "reiniciar";
            this.reiniciar.Size = new System.Drawing.Size(94, 29);
            this.reiniciar.TabIndex = 1;
            this.reiniciar.Text = "Reiniciar";
            this.reiniciar.UseVisualStyleBackColor = true;
            this.reiniciar.Click += new System.EventHandler(this.reiniciar_Click);
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(29, 117);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(68, 20);
            this.c1.TabIndex = 2;
            this.c1.Text = "Caballo1";
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Location = new System.Drawing.Point(29, 195);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(68, 20);
            this.c2.TabIndex = 3;
            this.c2.Text = "Caballo2";
            this.c2.Click += new System.EventHandler(this.label2_Click);
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Location = new System.Drawing.Point(29, 283);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(68, 20);
            this.c3.TabIndex = 4;
            this.c3.Text = "Caballo3";
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Location = new System.Drawing.Point(29, 372);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(68, 20);
            this.c4.TabIndex = 5;
            this.c4.Text = "Caballo4";
            // 
            // resul
            // 
            this.resul.AutoSize = true;
            this.resul.Location = new System.Drawing.Point(681, 137);
            this.resul.Name = "resul";
            this.resul.Size = new System.Drawing.Size(75, 20);
            this.resul.TabIndex = 6;
            this.resul.Text = "Resultado";
            this.resul.Click += new System.EventHandler(this.resul_Click);
            // 
            // progCab1
            // 
            this.progCab1.Location = new System.Drawing.Point(161, 108);
            this.progCab1.Name = "progCab1";
            this.progCab1.Size = new System.Drawing.Size(436, 29);
            this.progCab1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progCab1.TabIndex = 7;
            this.progCab1.Click += new System.EventHandler(this.progCab1_Click);
            // 
            // progCab2
            // 
            this.progCab2.Location = new System.Drawing.Point(161, 186);
            this.progCab2.Name = "progCab2";
            this.progCab2.Size = new System.Drawing.Size(436, 29);
            this.progCab2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progCab2.TabIndex = 8;
            // 
            // progCab3
            // 
            this.progCab3.Location = new System.Drawing.Point(161, 274);
            this.progCab3.Name = "progCab3";
            this.progCab3.Size = new System.Drawing.Size(436, 29);
            this.progCab3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progCab3.TabIndex = 9;
            // 
            // progCab4
            // 
            this.progCab4.Location = new System.Drawing.Point(161, 363);
            this.progCab4.Name = "progCab4";
            this.progCab4.Size = new System.Drawing.Size(436, 29);
            this.progCab4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progCab4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progCab4);
            this.Controls.Add(this.progCab3);
            this.Controls.Add(this.progCab2);
            this.Controls.Add(this.progCab1);
            this.Controls.Add(this.resul);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.reiniciar);
            this.Controls.Add(this.empezar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button empezar;
        private Button reiniciar;
        private Label c1;
        private Label c2;
        private Label c3;
        private Label c4;
        private Label resul;
        private ProgressBar progCab1;
        private ProgressBar progCab2;
        private ProgressBar progCab3;
        private ProgressBar progCab4;
    }
}