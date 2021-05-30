
namespace AgencijaNekretnine.Forme
{
    partial class KvartoviFormcs
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
            this.listaKvartova = new System.Windows.Forms.ListView();
            this.btnDodajKvart = new System.Windows.Forms.Button();
            this.btnIzmeniKvart = new System.Windows.Forms.Button();
            this.btnObrisiKvart = new System.Windows.Forms.Button();
            this.btnNekretnineKvarta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.nmudZona = new System.Windows.Forms.NumericUpDown();
            this.nmudIDPoslovnice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudZona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudIDPoslovnice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaKvartova);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listaKvartova
            // 
            this.listaKvartova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listaKvartova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaKvartova.FullRowSelect = true;
            this.listaKvartova.GridLines = true;
            this.listaKvartova.HideSelection = false;
            this.listaKvartova.Location = new System.Drawing.Point(3, 23);
            this.listaKvartova.Margin = new System.Windows.Forms.Padding(4);
            this.listaKvartova.Name = "listaKvartova";
            this.listaKvartova.Size = new System.Drawing.Size(460, 406);
            this.listaKvartova.TabIndex = 0;
            this.listaKvartova.UseCompatibleStateImageBehavior = false;
            this.listaKvartova.View = System.Windows.Forms.View.Details;
            // 
            // btnDodajKvart
            // 
            this.btnDodajKvart.Location = new System.Drawing.Point(524, 36);
            this.btnDodajKvart.Name = "btnDodajKvart";
            this.btnDodajKvart.Size = new System.Drawing.Size(221, 36);
            this.btnDodajKvart.TabIndex = 1;
            this.btnDodajKvart.Text = "Dodaj kvart";
            this.btnDodajKvart.UseVisualStyleBackColor = true;
            this.btnDodajKvart.Click += new System.EventHandler(this.btnDodajKvart_Click);
            // 
            // btnIzmeniKvart
            // 
            this.btnIzmeniKvart.Location = new System.Drawing.Point(524, 102);
            this.btnIzmeniKvart.Name = "btnIzmeniKvart";
            this.btnIzmeniKvart.Size = new System.Drawing.Size(220, 35);
            this.btnIzmeniKvart.TabIndex = 2;
            this.btnIzmeniKvart.Text = "Izmeni kvart";
            this.btnIzmeniKvart.UseVisualStyleBackColor = true;
            this.btnIzmeniKvart.Click += new System.EventHandler(this.btnIzmeniKvart_Click);
            // 
            // btnObrisiKvart
            // 
            this.btnObrisiKvart.Location = new System.Drawing.Point(524, 160);
            this.btnObrisiKvart.Name = "btnObrisiKvart";
            this.btnObrisiKvart.Size = new System.Drawing.Size(221, 34);
            this.btnObrisiKvart.TabIndex = 3;
            this.btnObrisiKvart.Text = "Obrisi kvart";
            this.btnObrisiKvart.UseVisualStyleBackColor = true;
            this.btnObrisiKvart.Click += new System.EventHandler(this.btnObrisiKvart_Click);
            // 
            // btnNekretnineKvarta
            // 
            this.btnNekretnineKvarta.Location = new System.Drawing.Point(523, 217);
            this.btnNekretnineKvarta.Name = "btnNekretnineKvarta";
            this.btnNekretnineKvarta.Size = new System.Drawing.Size(221, 37);
            this.btnNekretnineKvarta.TabIndex = 4;
            this.btnNekretnineKvarta.Text = "Sve nekretnine u kvartu";
            this.btnNekretnineKvarta.UseVisualStyleBackColor = true;
            this.btnNekretnineKvarta.Click += new System.EventHandler(this.btnNekretnineKvarta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zona kvarta: ";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IDKvarta";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zona";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IDPoslovnice";
            // 
            // nmudZona
            // 
            this.nmudZona.Location = new System.Drawing.Point(523, 317);
            this.nmudZona.Name = "nmudZona";
            this.nmudZona.Size = new System.Drawing.Size(220, 27);
            this.nmudZona.TabIndex = 7;
            // 
            // nmudIDPoslovnice
            // 
            this.nmudIDPoslovnice.Location = new System.Drawing.Point(522, 395);
            this.nmudIDPoslovnice.Name = "nmudIDPoslovnice";
            this.nmudIDPoslovnice.Size = new System.Drawing.Size(223, 27);
            this.nmudIDPoslovnice.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "IDPoslovnice";
            // 
            // KvartoviFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmudIDPoslovnice);
            this.Controls.Add(this.nmudZona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNekretnineKvarta);
            this.Controls.Add(this.btnObrisiKvart);
            this.Controls.Add(this.btnIzmeniKvart);
            this.Controls.Add(this.btnDodajKvart);
            this.Controls.Add(this.groupBox1);
            this.Name = "KvartoviFormcs";
            this.Text = "KvartoviFormcs";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmudZona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudIDPoslovnice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaKvartova;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDodajKvart;
        private System.Windows.Forms.Button btnIzmeniKvart;
        private System.Windows.Forms.Button btnObrisiKvart;
        private System.Windows.Forms.Button btnNekretnineKvarta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmudZona;
        private System.Windows.Forms.NumericUpDown nmudIDPoslovnice;
        private System.Windows.Forms.Label label2;
    }
}