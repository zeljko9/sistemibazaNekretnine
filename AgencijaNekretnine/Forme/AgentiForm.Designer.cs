
namespace AgencijaNekretnine.Forme
{
    partial class AgentiForm
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
            this.listaAgenata = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisiAgenta = new System.Windows.Forms.Button();
            this.btnIzmeniAgenta = new System.Windows.Forms.Button();
            this.btnDodajAgenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaAgenata);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listaAgenata
            // 
            this.listaAgenata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listaAgenata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaAgenata.FullRowSelect = true;
            this.listaAgenata.GridLines = true;
            this.listaAgenata.HideSelection = false;
            this.listaAgenata.Location = new System.Drawing.Point(3, 23);
            this.listaAgenata.Name = "listaAgenata";
            this.listaAgenata.Size = new System.Drawing.Size(456, 392);
            this.listaAgenata.TabIndex = 0;
            this.listaAgenata.UseCompatibleStateImageBehavior = false;
            this.listaAgenata.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IDProdavca";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Procenat";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "DatRada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiAgenta);
            this.groupBox2.Controls.Add(this.btnIzmeniAgenta);
            this.groupBox2.Controls.Add(this.btnDodajAgenta);
            this.groupBox2.Location = new System.Drawing.Point(496, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnObrisiAgenta
            // 
            this.btnObrisiAgenta.Location = new System.Drawing.Point(24, 168);
            this.btnObrisiAgenta.Name = "btnObrisiAgenta";
            this.btnObrisiAgenta.Size = new System.Drawing.Size(228, 36);
            this.btnObrisiAgenta.TabIndex = 2;
            this.btnObrisiAgenta.Text = "Obrisi Agenta";
            this.btnObrisiAgenta.UseVisualStyleBackColor = true;
            this.btnObrisiAgenta.Click += new System.EventHandler(this.btnObrisiAgenta_Click);
            // 
            // btnIzmeniAgenta
            // 
            this.btnIzmeniAgenta.Location = new System.Drawing.Point(24, 109);
            this.btnIzmeniAgenta.Name = "btnIzmeniAgenta";
            this.btnIzmeniAgenta.Size = new System.Drawing.Size(227, 35);
            this.btnIzmeniAgenta.TabIndex = 1;
            this.btnIzmeniAgenta.Text = "Izmeni Agenta";
            this.btnIzmeniAgenta.UseVisualStyleBackColor = true;
            this.btnIzmeniAgenta.Click += new System.EventHandler(this.btnIzmeniAgenta_Click);
            // 
            // btnDodajAgenta
            // 
            this.btnDodajAgenta.Location = new System.Drawing.Point(24, 47);
            this.btnDodajAgenta.Name = "btnDodajAgenta";
            this.btnDodajAgenta.Size = new System.Drawing.Size(228, 33);
            this.btnDodajAgenta.TabIndex = 0;
            this.btnDodajAgenta.Text = "Dodaj agenta";
            this.btnDodajAgenta.UseVisualStyleBackColor = true;
            this.btnDodajAgenta.Click += new System.EventHandler(this.btnDodajAgenta_Click);
            // 
            // AgentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgentiForm";
            this.Text = "AgentiForm";
            this.Load += new System.EventHandler(this.AgentiForm_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaAgenata;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObrisiAgenta;
        private System.Windows.Forms.Button btnIzmeniAgenta;
        private System.Windows.Forms.Button btnDodajAgenta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}