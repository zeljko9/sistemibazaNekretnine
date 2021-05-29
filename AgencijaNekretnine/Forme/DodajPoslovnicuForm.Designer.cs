
namespace AgencijaNekretnine.Forme
{
    partial class DodajPoslovnicuForm
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
            this.tbxAdresaPoslovnice = new System.Windows.Forms.TextBox();
            this.tbxRadniDani = new System.Windows.Forms.TextBox();
            this.tbxSubota = new System.Windows.Forms.TextBox();
            this.tbxNedelja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajPoslovnicu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxAdresaPoslovnice
            // 
            this.tbxAdresaPoslovnice.Location = new System.Drawing.Point(52, 96);
            this.tbxAdresaPoslovnice.Name = "tbxAdresaPoslovnice";
            this.tbxAdresaPoslovnice.Size = new System.Drawing.Size(220, 27);
            this.tbxAdresaPoslovnice.TabIndex = 0;
            // 
            // tbxRadniDani
            // 
            this.tbxRadniDani.Location = new System.Drawing.Point(488, 96);
            this.tbxRadniDani.Name = "tbxRadniDani";
            this.tbxRadniDani.Size = new System.Drawing.Size(220, 27);
            this.tbxRadniDani.TabIndex = 1;
            // 
            // tbxSubota
            // 
            this.tbxSubota.Location = new System.Drawing.Point(488, 190);
            this.tbxSubota.Name = "tbxSubota";
            this.tbxSubota.Size = new System.Drawing.Size(220, 27);
            this.tbxSubota.TabIndex = 3;
            // 
            // tbxNedelja
            // 
            this.tbxNedelja.Location = new System.Drawing.Point(488, 272);
            this.tbxNedelja.Name = "tbxNedelja";
            this.tbxNedelja.Size = new System.Drawing.Size(220, 27);
            this.tbxNedelja.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adresa poslovnice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radno vreme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Radnim danima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nedelja";
            // 
            // btnDodajPoslovnicu
            // 
            this.btnDodajPoslovnicu.Location = new System.Drawing.Point(267, 371);
            this.btnDodajPoslovnicu.Name = "btnDodajPoslovnicu";
            this.btnDodajPoslovnicu.Size = new System.Drawing.Size(212, 29);
            this.btnDodajPoslovnicu.TabIndex = 11;
            this.btnDodajPoslovnicu.Text = "Dodaj";
            this.btnDodajPoslovnicu.UseVisualStyleBackColor = true;
            this.btnDodajPoslovnicu.Click += new System.EventHandler(this.btnDodajPoslovnicu_Click);
            // 
            // DodajPoslovnicuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajPoslovnicu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNedelja);
            this.Controls.Add(this.tbxSubota);
            this.Controls.Add(this.tbxRadniDani);
            this.Controls.Add(this.tbxAdresaPoslovnice);
            this.Name = "DodajPoslovnicuForm";
            this.Text = "DodajPoslovnicuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAdresaPoslovnice;
        private System.Windows.Forms.TextBox tbxRadniDani;
        private System.Windows.Forms.TextBox tbxSubota;
        private System.Windows.Forms.TextBox tbxNedelja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodajPoslovnicu;
    }
}