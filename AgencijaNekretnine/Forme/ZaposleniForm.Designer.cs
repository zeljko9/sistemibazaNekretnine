
namespace AgencijaNekretnine.Forme
{
    partial class ZaposleniForm
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
            this.zaposleni = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Ime = new System.Windows.Forms.ColumnHeader();
            this.Prezime = new System.Windows.Forms.ColumnHeader();
            this.DatZaposlenja = new System.Windows.Forms.ColumnHeader();
            this.IDProdavnice = new System.Windows.Forms.ColumnHeader();
            this.Sef = new System.Windows.Forms.ColumnHeader();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.btnIzmeniZaposlenog = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPrikazSefova = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zaposleni
            // 
            this.zaposleni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Ime,
            this.Prezime,
            this.DatZaposlenja,
            this.IDProdavnice,
            this.Sef});
            this.zaposleni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zaposleni.FullRowSelect = true;
            this.zaposleni.GridLines = true;
            this.zaposleni.HideSelection = false;
            this.zaposleni.Location = new System.Drawing.Point(0, 0);
            this.zaposleni.Margin = new System.Windows.Forms.Padding(4);
            this.zaposleni.Name = "zaposleni";
            this.zaposleni.Size = new System.Drawing.Size(800, 450);
            this.zaposleni.TabIndex = 0;
            this.zaposleni.UseCompatibleStateImageBehavior = false;
            this.zaposleni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JMBG";
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            // 
            // DatZaposlenja
            // 
            this.DatZaposlenja.Text = "DatZaposlenja";
            // 
            // IDProdavnice
            // 
            this.IDProdavnice.Text = "IDProdavnice";
            // 
            // Sef
            // 
            this.Sef.Text = "StrucnaSprema";
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(551, 37);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(202, 29);
            this.btnDodajZaposlenog.TabIndex = 1;
            this.btnDodajZaposlenog.Text = "Dodaj novog zaposlenog";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // btnIzmeniZaposlenog
            // 
            this.btnIzmeniZaposlenog.Location = new System.Drawing.Point(551, 95);
            this.btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            this.btnIzmeniZaposlenog.Size = new System.Drawing.Size(202, 29);
            this.btnIzmeniZaposlenog.TabIndex = 2;
            this.btnIzmeniZaposlenog.Text = "Izmeni zaposlenog";
            this.btnIzmeniZaposlenog.UseVisualStyleBackColor = true;
            this.btnIzmeniZaposlenog.Click += new System.EventHandler(this.btnIzmeniZaposlenog_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "ObrisiZaposlenog";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPrikazSefova
            // 
            this.btnPrikazSefova.Location = new System.Drawing.Point(551, 229);
            this.btnPrikazSefova.Name = "btnPrikazSefova";
            this.btnPrikazSefova.Size = new System.Drawing.Size(202, 29);
            this.btnPrikazSefova.TabIndex = 4;
            this.btnPrikazSefova.Text = "PrikaziSefove";
            this.btnPrikazSefova.UseVisualStyleBackColor = true;
            this.btnPrikazSefova.Click += new System.EventHandler(this.btnPrikazSefova_Click);
            // 
            // ZaposleniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazSefova);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnIzmeniZaposlenog);
            this.Controls.Add(this.btnDodajZaposlenog);
            this.Controls.Add(this.zaposleni);
            this.Name = "ZaposleniForm";
            this.Text = "ZaposleniForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView zaposleni;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.Button btnIzmeniZaposlenog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPrikazSefova;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader DatZaposlenja;
        private System.Windows.Forms.ColumnHeader IDProdavnice;
        private System.Windows.Forms.ColumnHeader Sef;
    }
}