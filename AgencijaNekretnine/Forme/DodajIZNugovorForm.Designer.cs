
namespace AgencijaNekretnine.Forme
{
    partial class DodajIZNugovorForm
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.textKupac = new System.Windows.Forms.TextBox();
            this.textProdavac = new System.Windows.Forms.TextBox();
            this.textUlicaBroj = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(274, 232);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(111, 39);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // textKupac
            // 
            this.textKupac.Location = new System.Drawing.Point(240, 57);
            this.textKupac.Name = "textKupac";
            this.textKupac.Size = new System.Drawing.Size(145, 27);
            this.textKupac.TabIndex = 1;
            // 
            // textProdavac
            // 
            this.textProdavac.Location = new System.Drawing.Point(240, 123);
            this.textProdavac.Name = "textProdavac";
            this.textProdavac.Size = new System.Drawing.Size(145, 27);
            this.textProdavac.TabIndex = 2;
            // 
            // textUlicaBroj
            // 
            this.textUlicaBroj.Location = new System.Drawing.Point(240, 90);
            this.textUlicaBroj.Name = "textUlicaBroj";
            this.textUlicaBroj.Size = new System.Drawing.Size(145, 27);
            this.textUlicaBroj.TabIndex = 3;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(240, 156);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(145, 27);
            this.dateTime.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "JMBG iznajmljivaca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum isteka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "JMBG prodavca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ulica i broj nekretnine";
            // 
            // DodajIZNugovorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 315);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.textUlicaBroj);
            this.Controls.Add(this.textProdavac);
            this.Controls.Add(this.textKupac);
            this.Controls.Add(this.btnDodaj);
            this.Name = "DodajIZNugovorForm";
            this.Text = "DodajIZNugovorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox textKupac;
        private System.Windows.Forms.TextBox textProdavac;
        private System.Windows.Forms.TextBox textUlicaBroj;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}