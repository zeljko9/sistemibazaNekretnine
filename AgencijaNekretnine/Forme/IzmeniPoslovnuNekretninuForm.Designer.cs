
namespace AgencijaNekretnine.Forme
{
    partial class IzmeniPoslovnuNekretninuForm
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
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textUlica = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSprat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            this.SuspendLayout();
            // 
            // numSprat
            // 
            this.numSprat.Location = new System.Drawing.Point(311, 101);
            this.numSprat.Name = "numSprat";
            this.numSprat.Size = new System.Drawing.Size(179, 27);
            this.numSprat.TabIndex = 39;
            this.numSprat.ValueChanged += new System.EventHandler(this.numSprat_ValueChanged);
            // 
            // numBroj
            // 
            this.numBroj.Location = new System.Drawing.Point(311, 68);
            this.numBroj.Name = "numBroj";
            this.numBroj.Size = new System.Drawing.Size(179, 27);
            this.numBroj.TabIndex = 38;
            this.numBroj.ValueChanged += new System.EventHandler(this.numBroj_ValueChanged);
            // 
            // numCena
            // 
            this.numCena.Location = new System.Drawing.Point(311, 167);
            this.numCena.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(179, 27);
            this.numCena.TabIndex = 37;
            this.numCena.ValueChanged += new System.EventHandler(this.numCena_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cena";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 27);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(324, 280);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(166, 39);
            this.btnIzmeni.TabIndex = 34;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Datum izgradnje";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Sprat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Broj";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ulica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textUlica
            // 
            this.textUlica.Location = new System.Drawing.Point(311, 35);
            this.textUlica.Name = "textUlica";
            this.textUlica.Size = new System.Drawing.Size(179, 27);
            this.textUlica.TabIndex = 29;
            this.textUlica.TextChanged += new System.EventHandler(this.textUlica_TextChanged);
            // 
            // IzmeniPoslovnuNekretninuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 335);
            this.Controls.Add(this.numSprat);
            this.Controls.Add(this.numBroj);
            this.Controls.Add(this.numCena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUlica);
            this.Name = "IzmeniPoslovnuNekretninuForm";
            this.Text = "IzmeniPoslovnuNekretninuForm";
            this.Load += new System.EventHandler(this.IzmeniPoslovnuNekretninuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSprat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSprat;
        private System.Windows.Forms.NumericUpDown numBroj;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUlica;
    }
}