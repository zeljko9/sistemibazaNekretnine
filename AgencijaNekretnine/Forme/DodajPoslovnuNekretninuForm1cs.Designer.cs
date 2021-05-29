
namespace AgencijaNekretnine.Forme
{
    partial class DodajPoslovnuNekretninuForm1cs
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
            this.numSprat = new System.Windows.Forms.NumericUpDown();
            this.numBroj = new System.Windows.Forms.NumericUpDown();
            this.nmbCena = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textUlica = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSprat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCena)).BeginInit();
            this.SuspendLayout();
            // 
            // numSprat
            // 
            this.numSprat.Location = new System.Drawing.Point(293, 101);
            this.numSprat.Name = "numSprat";
            this.numSprat.Size = new System.Drawing.Size(179, 27);
            this.numSprat.TabIndex = 28;
            // 
            // numBroj
            // 
            this.numBroj.Location = new System.Drawing.Point(293, 68);
            this.numBroj.Name = "numBroj";
            this.numBroj.Size = new System.Drawing.Size(179, 27);
            this.numBroj.TabIndex = 27;
            // 
            // nmbCena
            // 
            this.nmbCena.Location = new System.Drawing.Point(293, 167);
            this.nmbCena.Name = "nmbCena";
            this.nmbCena.Size = new System.Drawing.Size(179, 27);
            this.nmbCena.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cena";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 27);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(306, 280);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(166, 39);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Datum izgradnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sprat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Broj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ulica";
            // 
            // textUlica
            // 
            this.textUlica.Location = new System.Drawing.Point(293, 35);
            this.textUlica.Name = "textUlica";
            this.textUlica.Size = new System.Drawing.Size(179, 27);
            this.textUlica.TabIndex = 17;
            // 
            // DodajPoslovnuNekretninuForm1cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 336);
            this.Controls.Add(this.numSprat);
            this.Controls.Add(this.numBroj);
            this.Controls.Add(this.nmbCena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUlica);
            this.Name = "DodajPoslovnuNekretninuForm1cs";
            this.Text = "DodajPoslovnuNekretninuForm1cs";
            ((System.ComponentModel.ISupportInitialize)(this.numSprat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numSprat;
        private System.Windows.Forms.NumericUpDown numBroj;
        private System.Windows.Forms.NumericUpDown nmbCena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUlica;
    }
}