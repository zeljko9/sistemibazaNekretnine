
namespace AgencijaNekretnine.Forme
{
    partial class DodajAgentaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.nmudProcenat = new System.Windows.Forms.NumericUpDown();
            this.dtpDatRada = new System.Windows.Forms.DateTimePicker();
            this.btnDodajAgenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmudProcenat)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DatPocetka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Procenat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "BrTel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ime";
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(56, 198);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(132, 27);
            this.tbxIme.TabIndex = 6;
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(56, 291);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(132, 27);
            this.tbxTelefon.TabIndex = 8;
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(285, 198);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(132, 27);
            this.tbxPrezime.TabIndex = 9;
            // 
            // nmudProcenat
            // 
            this.nmudProcenat.Location = new System.Drawing.Point(285, 291);
            this.nmudProcenat.Name = "nmudProcenat";
            this.nmudProcenat.Size = new System.Drawing.Size(153, 27);
            this.nmudProcenat.TabIndex = 10;
            // 
            // dtpDatRada
            // 
            this.dtpDatRada.Location = new System.Drawing.Point(523, 198);
            this.dtpDatRada.Name = "dtpDatRada";
            this.dtpDatRada.Size = new System.Drawing.Size(204, 27);
            this.dtpDatRada.TabIndex = 11;
            // 
            // btnDodajAgenta
            // 
            this.btnDodajAgenta.Location = new System.Drawing.Point(490, 364);
            this.btnDodajAgenta.Name = "btnDodajAgenta";
            this.btnDodajAgenta.Size = new System.Drawing.Size(237, 54);
            this.btnDodajAgenta.TabIndex = 12;
            this.btnDodajAgenta.Text = "Dodaj agenta";
            this.btnDodajAgenta.UseVisualStyleBackColor = true;
            this.btnDodajAgenta.Click += new System.EventHandler(this.btnDodajAgenta_Click);
            // 
            // DodajAgentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajAgenta);
            this.Controls.Add(this.dtpDatRada);
            this.Controls.Add(this.nmudProcenat);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DodajAgentaForm";
            this.Text = "DodajAgentaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmudProcenat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.NumericUpDown nmudProcenat;
        private System.Windows.Forms.DateTimePicker dtpDatRada;
        private System.Windows.Forms.Button btnDodajAgenta;
    }
}