
namespace AgencijaNekretnine.Forme
{
    partial class IznajmUgovorForm
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
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listUgovori = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(779, 165);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(196, 52);
            this.btnIzmeni.TabIndex = 7;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(780, 107);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(196, 52);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(779, 49);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(196, 52);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // listUgovori
            // 
            this.listUgovori.HideSelection = false;
            this.listUgovori.Location = new System.Drawing.Point(12, 12);
            this.listUgovori.Name = "listUgovori";
            this.listUgovori.Size = new System.Drawing.Size(750, 526);
            this.listUgovori.TabIndex = 4;
            this.listUgovori.UseCompatibleStateImageBehavior = false;
            // 
            // IznajmUgovorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 578);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listUgovori);
            this.Name = "IznajmUgovorForm";
            this.Text = "IznajmUgovorForm";
            this.Load += new System.EventHandler(this.IznajmUgovorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView listUgovori;
    }
}