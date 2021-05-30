
namespace AgencijaNekretnine.Forme
{
    partial class LicaForm
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
            this.listaLica = new System.Windows.Forms.ListView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.btnDodajFon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaLica
            // 
            this.listaLica.HideSelection = false;
            this.listaLica.Location = new System.Drawing.Point(12, 12);
            this.listaLica.Name = "listaLica";
            this.listaLica.Size = new System.Drawing.Size(561, 439);
            this.listaLica.TabIndex = 0;
            this.listaLica.UseCompatibleStateImageBehavior = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(579, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(163, 56);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj lice";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(579, 74);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(163, 56);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi lice";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(579, 136);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(163, 56);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Izmeni lice";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(579, 354);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(163, 27);
            this.textTelefon.TabIndex = 4;
            // 
            // btnDodajFon
            // 
            this.btnDodajFon.Location = new System.Drawing.Point(579, 387);
            this.btnDodajFon.Name = "btnDodajFon";
            this.btnDodajFon.Size = new System.Drawing.Size(163, 29);
            this.btnDodajFon.TabIndex = 5;
            this.btnDodajFon.Text = "Dodaj telefon";
            this.btnDodajFon.UseVisualStyleBackColor = true;
            this.btnDodajFon.Click += new System.EventHandler(this.btnDodajFon_Click);
            // 
            // LicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 463);
            this.Controls.Add(this.btnDodajFon);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listaLica);
            this.Name = "LicaForm";
            this.Text = "LicaForm";
            this.Load += new System.EventHandler(this.LicaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaLica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.Button btnDodajFon;
    }
}