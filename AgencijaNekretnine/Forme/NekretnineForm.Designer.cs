
namespace AgencijaNekretnine.Forme
{
    partial class NekretnineForm
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
            this.listNekretnine = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnDodajStambenu = new System.Windows.Forms.Button();
            this.btnDodajPoslovnu = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOprema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listNekretnine
            // 
            this.listNekretnine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listNekretnine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNekretnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listNekretnine.FullRowSelect = true;
            this.listNekretnine.GridLines = true;
            this.listNekretnine.HideSelection = false;
            this.listNekretnine.Location = new System.Drawing.Point(0, 0);
            this.listNekretnine.Margin = new System.Windows.Forms.Padding(4);
            this.listNekretnine.Name = "listNekretnine";
            this.listNekretnine.Size = new System.Drawing.Size(1088, 463);
            this.listNekretnine.TabIndex = 4;
            this.listNekretnine.UseCompatibleStateImageBehavior = false;
            this.listNekretnine.View = System.Windows.Forms.View.Details;
            this.listNekretnine.SelectedIndexChanged += new System.EventHandler(this.listNekretnine_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IDNekretnine";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ulica";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Broj";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sprat";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Starost";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cena";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tip";
            // 
            // btnDodajStambenu
            // 
            this.btnDodajStambenu.Location = new System.Drawing.Point(815, 18);
            this.btnDodajStambenu.Name = "btnDodajStambenu";
            this.btnDodajStambenu.Size = new System.Drawing.Size(233, 46);
            this.btnDodajStambenu.TabIndex = 1;
            this.btnDodajStambenu.Text = "Dodaj stambenu nekretninu";
            this.btnDodajStambenu.UseVisualStyleBackColor = true;
            this.btnDodajStambenu.Click += new System.EventHandler(this.btnDodajStambenu_Click);
            // 
            // btnDodajPoslovnu
            // 
            this.btnDodajPoslovnu.Location = new System.Drawing.Point(816, 70);
            this.btnDodajPoslovnu.Name = "btnDodajPoslovnu";
            this.btnDodajPoslovnu.Size = new System.Drawing.Size(232, 46);
            this.btnDodajPoslovnu.TabIndex = 2;
            this.btnDodajPoslovnu.Text = "Dodaj poslovnu nekretninu";
            this.btnDodajPoslovnu.UseVisualStyleBackColor = true;
            this.btnDodajPoslovnu.Click += new System.EventHandler(this.btnDodajPoslovnu_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(816, 122);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(232, 46);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(816, 174);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(232, 46);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOprema
            // 
            this.btnOprema.Location = new System.Drawing.Point(816, 320);
            this.btnOprema.Name = "btnOprema";
            this.btnOprema.Size = new System.Drawing.Size(232, 46);
            this.btnOprema.TabIndex = 5;
            this.btnOprema.Text = "Upravljaj opremom";
            this.btnOprema.UseVisualStyleBackColor = true;
            this.btnOprema.Click += new System.EventHandler(this.btnOprema_Click);
            // 
            // NekretnineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 463);
            this.Controls.Add(this.btnOprema);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodajPoslovnu);
            this.Controls.Add(this.btnDodajStambenu);
            this.Controls.Add(this.listNekretnine);
            this.Name = "NekretnineForm";
            this.Text = "NekretnineForm";
            this.Load += new System.EventHandler(this.NekretnineForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listNekretnine;
        private System.Windows.Forms.Button btnDodajStambenu;
        private System.Windows.Forms.Button btnDodajPoslovnu;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOprema;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}