﻿
namespace AgencijaNekretnine.Forme
{
    partial class DodajZaposlenogForm
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
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.dtpDatZaposlenja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.nmupJMBG = new System.Windows.Forms.NumericUpDown();
            this.tbxStrucnaSprema = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmupJMBG)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(38, 283);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(190, 27);
            this.tbxPrezime.TabIndex = 1;
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(38, 182);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(190, 27);
            this.tbxIme.TabIndex = 2;
            // 
            // dtpDatZaposlenja
            // 
            this.dtpDatZaposlenja.Location = new System.Drawing.Point(424, 89);
            this.dtpDatZaposlenja.Name = "dtpDatZaposlenja";
            this.dtpDatZaposlenja.Size = new System.Drawing.Size(292, 27);
            this.dtpDatZaposlenja.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "DatZaposlenja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "JMBG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prezime";
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(403, 355);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(272, 55);
            this.btnDodajZaposlenog.TabIndex = 8;
            this.btnDodajZaposlenog.Text = "Dodaj";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // nmupJMBG
            // 
            this.nmupJMBG.Location = new System.Drawing.Point(38, 92);
            this.nmupJMBG.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nmupJMBG.Name = "nmupJMBG";
            this.nmupJMBG.Size = new System.Drawing.Size(191, 27);
            this.nmupJMBG.TabIndex = 9;
            // 
            // tbxStrucnaSprema
            // 
            this.tbxStrucnaSprema.Location = new System.Drawing.Point(428, 173);
            this.tbxStrucnaSprema.Name = "tbxStrucnaSprema";
            this.tbxStrucnaSprema.Size = new System.Drawing.Size(287, 27);
            this.tbxStrucnaSprema.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "StrucnaSprema";
            // 
            // DodajZaposlenogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxStrucnaSprema);
            this.Controls.Add(this.nmupJMBG);
            this.Controls.Add(this.btnDodajZaposlenog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatZaposlenja);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.tbxPrezime);
            this.Name = "DodajZaposlenogForm";
            this.Text = "DodajZaposlenogForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmupJMBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.DateTimePicker dtpDatZaposlenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.NumericUpDown nmupJMBG;
        private System.Windows.Forms.TextBox tbxStrucnaSprema;
        private System.Windows.Forms.Label label5;
    }
}