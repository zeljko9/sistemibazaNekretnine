
namespace AgencijaNekretnine.Forme
{
    partial class PoslovniceForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.poslovnice = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisiPoslovnicu = new System.Windows.Forms.Button();
            this.btnIzmeniPoslovnicu = new System.Windows.Forms.Button();
            this.btnDodajPoslovnicu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnZaposleniPoslovnice = new System.Windows.Forms.Button();
            this.btnSefoviPrikaz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.poslovnice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // poslovnice
            // 
            this.poslovnice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.poslovnice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poslovnice.FullRowSelect = true;
            this.poslovnice.GridLines = true;
            this.poslovnice.HideSelection = false;
            this.poslovnice.Location = new System.Drawing.Point(3, 23);
            this.poslovnice.Name = "poslovnice";
            this.poslovnice.Size = new System.Drawing.Size(474, 375);
            this.poslovnice.TabIndex = 0;
            this.poslovnice.UseCompatibleStateImageBehavior = false;
            this.poslovnice.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IDPoslovnice";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adresa";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RadnoVreme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiPoslovnicu);
            this.groupBox2.Controls.Add(this.btnIzmeniPoslovnicu);
            this.groupBox2.Controls.Add(this.btnDodajPoslovnicu);
            this.groupBox2.Location = new System.Drawing.Point(529, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnObrisiPoslovnicu
            // 
            this.btnObrisiPoslovnicu.Location = new System.Drawing.Point(19, 110);
            this.btnObrisiPoslovnicu.Name = "btnObrisiPoslovnicu";
            this.btnObrisiPoslovnicu.Size = new System.Drawing.Size(207, 36);
            this.btnObrisiPoslovnicu.TabIndex = 2;
            this.btnObrisiPoslovnicu.Text = "Obrisi poslovnicu";
            this.btnObrisiPoslovnicu.UseVisualStyleBackColor = true;
            this.btnObrisiPoslovnicu.Click += new System.EventHandler(this.btnObrisiPoslovnicu_Click);
            // 
            // btnIzmeniPoslovnicu
            // 
            this.btnIzmeniPoslovnicu.Location = new System.Drawing.Point(19, 68);
            this.btnIzmeniPoslovnicu.Name = "btnIzmeniPoslovnicu";
            this.btnIzmeniPoslovnicu.Size = new System.Drawing.Size(207, 36);
            this.btnIzmeniPoslovnicu.TabIndex = 1;
            this.btnIzmeniPoslovnicu.Text = "Izmeni poslovnicu";
            this.btnIzmeniPoslovnicu.UseVisualStyleBackColor = true;
            this.btnIzmeniPoslovnicu.Click += new System.EventHandler(this.btnIzmeniPoslovnicu_Click);
            // 
            // btnDodajPoslovnicu
            // 
            this.btnDodajPoslovnicu.Location = new System.Drawing.Point(19, 26);
            this.btnDodajPoslovnicu.Name = "btnDodajPoslovnicu";
            this.btnDodajPoslovnicu.Size = new System.Drawing.Size(207, 36);
            this.btnDodajPoslovnicu.TabIndex = 0;
            this.btnDodajPoslovnicu.Text = "Dodaj poslovnicu";
            this.btnDodajPoslovnicu.UseVisualStyleBackColor = true;
            this.btnDodajPoslovnicu.Click += new System.EventHandler(this.btnDodajPoslovnicu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnZaposleniPoslovnice);
            this.groupBox3.Location = new System.Drawing.Point(529, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 147);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnZaposleniPoslovnice
            // 
            this.btnZaposleniPoslovnice.Location = new System.Drawing.Point(19, 55);
            this.btnZaposleniPoslovnice.Name = "btnZaposleniPoslovnice";
            this.btnZaposleniPoslovnice.Size = new System.Drawing.Size(207, 36);
            this.btnZaposleniPoslovnice.TabIndex = 1;
            this.btnZaposleniPoslovnice.Text = "Zaposleni poslovnice";
            this.btnZaposleniPoslovnice.UseVisualStyleBackColor = true;
            this.btnZaposleniPoslovnice.Click += new System.EventHandler(this.btnZaposleniPoslovnice_Click);
            // 
            // btnSefoviPrikaz
            // 
            this.btnSefoviPrikaz.Location = new System.Drawing.Point(548, 379);
            this.btnSefoviPrikaz.Name = "btnSefoviPrikaz";
            this.btnSefoviPrikaz.Size = new System.Drawing.Size(207, 34);
            this.btnSefoviPrikaz.TabIndex = 3;
            this.btnSefoviPrikaz.Text = "Prikaz svih sefova";
            this.btnSefoviPrikaz.UseVisualStyleBackColor = true;
            this.btnSefoviPrikaz.Click += new System.EventHandler(this.btnSefoviPrikaz_Click);
            // 
            // PoslovniceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.btnSefoviPrikaz);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PoslovniceForm";
            this.Text = "Upravljanje poslovnicom";
            this.Load += new System.EventHandler(this.PoslovniceForm_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView poslovnice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnObrisiPoslovnicu;
        private System.Windows.Forms.Button btnIzmeniPoslovnicu;
        private System.Windows.Forms.Button btnDodajPoslovnicu;
        private System.Windows.Forms.Button btnZaposleniPoslovnice;
        private System.Windows.Forms.Button btnSefoviPrikaz;
    }
}