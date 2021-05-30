
namespace AgencijaNekretnine.Forme
{
    partial class DodajStambenuNekretninuForm
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
            this.textUlica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nmbCena = new System.Windows.Forms.NumericUpDown();
            this.numBroj = new System.Windows.Forms.NumericUpDown();
            this.numSprat = new System.Windows.Forms.NumericUpDown();
            this.numBrojKupatila = new System.Windows.Forms.NumericUpDown();
            this.comboVlasnik = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSprat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojKupatila)).BeginInit();
            this.SuspendLayout();
            // 
            // textUlica
            // 
            this.textUlica.Location = new System.Drawing.Point(287, 27);
            this.textUlica.Name = "textUlica";
            this.textUlica.Size = new System.Drawing.Size(159, 27);
            this.textUlica.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ulica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sprat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj kupatila";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "izgradnje";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(301, 351);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(145, 38);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cena";
            // 
            // nmbCena
            // 
            this.nmbCena.Location = new System.Drawing.Point(287, 192);
            this.nmbCena.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmbCena.Name = "nmbCena";
            this.nmbCena.Size = new System.Drawing.Size(158, 27);
            this.nmbCena.TabIndex = 13;
            // 
            // numBroj
            // 
            this.numBroj.Location = new System.Drawing.Point(287, 60);
            this.numBroj.Name = "numBroj";
            this.numBroj.Size = new System.Drawing.Size(158, 27);
            this.numBroj.TabIndex = 14;
            // 
            // numSprat
            // 
            this.numSprat.Location = new System.Drawing.Point(287, 93);
            this.numSprat.Name = "numSprat";
            this.numSprat.Size = new System.Drawing.Size(158, 27);
            this.numSprat.TabIndex = 15;
            // 
            // numBrojKupatila
            // 
            this.numBrojKupatila.Location = new System.Drawing.Point(287, 126);
            this.numBrojKupatila.Name = "numBrojKupatila";
            this.numBrojKupatila.Size = new System.Drawing.Size(158, 27);
            this.numBrojKupatila.TabIndex = 16;
            // 
            // comboVlasnik
            // 
            this.comboVlasnik.FormattingEnabled = true;
            this.comboVlasnik.Location = new System.Drawing.Point(288, 225);
            this.comboVlasnik.Name = "comboVlasnik";
            this.comboVlasnik.Size = new System.Drawing.Size(158, 28);
            this.comboVlasnik.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Vlasnik";
            // 
            // DodajStambenuNekretninuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 467);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboVlasnik);
            this.Controls.Add(this.numBrojKupatila);
            this.Controls.Add(this.numSprat);
            this.Controls.Add(this.numBroj);
            this.Controls.Add(this.nmbCena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUlica);
            this.Name = "DodajStambenuNekretninuForm";
            this.Text = "DodajStambenuNekretninuForm";
            this.Load += new System.EventHandler(this.DodajStambenuNekretninuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSprat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojKupatila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUlica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmbCena;
        private System.Windows.Forms.NumericUpDown numBroj;
        private System.Windows.Forms.NumericUpDown numSprat;
        private System.Windows.Forms.NumericUpDown numBrojKupatila;
        private System.Windows.Forms.ComboBox comboVlasnik;
        private System.Windows.Forms.Label label7;
    }
}