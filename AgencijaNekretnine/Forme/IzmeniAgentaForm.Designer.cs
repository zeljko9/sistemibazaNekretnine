
namespace AgencijaNekretnine.Forme
{
    partial class IzmeniAgentaForm
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
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.tbxBrTel = new System.Windows.Forms.TextBox();
            this.nmudProcenat = new System.Windows.Forms.NumericUpDown();
            this.dtpDatPocetka = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIzmeniAgenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmudProcenat)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(24, 150);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(196, 27);
            this.tbxIme.TabIndex = 0;
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(351, 150);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(209, 27);
            this.tbxPrezime.TabIndex = 1;
            // 
            // tbxBrTel
            // 
            this.tbxBrTel.Location = new System.Drawing.Point(24, 245);
            this.tbxBrTel.Name = "tbxBrTel";
            this.tbxBrTel.Size = new System.Drawing.Size(196, 27);
            this.tbxBrTel.TabIndex = 2;
            // 
            // nmudProcenat
            // 
            this.nmudProcenat.Location = new System.Drawing.Point(347, 246);
            this.nmudProcenat.Name = "nmudProcenat";
            this.nmudProcenat.Size = new System.Drawing.Size(213, 27);
            this.nmudProcenat.TabIndex = 3;
            // 
            // dtpDatPocetka
            // 
            this.dtpDatPocetka.Location = new System.Drawing.Point(24, 370);
            this.dtpDatPocetka.Name = "dtpDatPocetka";
            this.dtpDatPocetka.Size = new System.Drawing.Size(210, 27);
            this.dtpDatPocetka.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "BrTel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "DatPocetka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Procenat";
            // 
            // btnIzmeniAgenta
            // 
            this.btnIzmeniAgenta.Location = new System.Drawing.Point(389, 368);
            this.btnIzmeniAgenta.Name = "btnIzmeniAgenta";
            this.btnIzmeniAgenta.Size = new System.Drawing.Size(278, 29);
            this.btnIzmeniAgenta.TabIndex = 10;
            this.btnIzmeniAgenta.Text = "Izmeni agenta";
            this.btnIzmeniAgenta.UseVisualStyleBackColor = true;
            this.btnIzmeniAgenta.Click += new System.EventHandler(this.btnIzmeniAgenta_Click);
            // 
            // IzmeniAgentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzmeniAgenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatPocetka);
            this.Controls.Add(this.nmudProcenat);
            this.Controls.Add(this.tbxBrTel);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.tbxIme);
            this.Name = "IzmeniAgentaForm";
            this.Text = "IzmeniAgentaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmudProcenat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.TextBox tbxBrTel;
        private System.Windows.Forms.NumericUpDown nmudProcenat;
        private System.Windows.Forms.DateTimePicker dtpDatPocetka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIzmeniAgenta;
    }
}