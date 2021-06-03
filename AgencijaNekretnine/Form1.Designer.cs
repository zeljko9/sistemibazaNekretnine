
namespace AgencijaNekretnine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNekretnine = new System.Windows.Forms.Button();
            this.btnUgovori = new System.Windows.Forms.Button();
            this.btnPoslovnice = new System.Windows.Forms.Button();
            this.btnKvartovi = new System.Windows.Forms.Button();
            this.btnLica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNekretnine
            // 
            this.btnNekretnine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNekretnine.Location = new System.Drawing.Point(119, 222);
            this.btnNekretnine.Name = "btnNekretnine";
            this.btnNekretnine.Size = new System.Drawing.Size(200, 74);
            this.btnNekretnine.TabIndex = 0;
            this.btnNekretnine.Text = "Nekretnine";
            this.btnNekretnine.UseVisualStyleBackColor = true;
            this.btnNekretnine.Click += new System.EventHandler(this.btnNekretnine_Click);
            // 
            // btnUgovori
            // 
            this.btnUgovori.Location = new System.Drawing.Point(119, 301);
            this.btnUgovori.Name = "btnUgovori";
            this.btnUgovori.Size = new System.Drawing.Size(199, 73);
            this.btnUgovori.TabIndex = 1;
            this.btnUgovori.Text = "Ugovori";
            this.btnUgovori.UseVisualStyleBackColor = true;
            this.btnUgovori.Click += new System.EventHandler(this.btnUgovori_Click);
            // 
            // btnPoslovnice
            // 
            this.btnPoslovnice.Location = new System.Drawing.Point(120, 151);
            this.btnPoslovnice.Name = "btnPoslovnice";
            this.btnPoslovnice.Size = new System.Drawing.Size(199, 65);
            this.btnPoslovnice.TabIndex = 3;
            this.btnPoslovnice.Text = "Poslovnice";
            this.btnPoslovnice.UseVisualStyleBackColor = true;
            this.btnPoslovnice.Click += new System.EventHandler(this.btnPoslovnice_Click);
            // 
            // btnKvartovi
            // 
            this.btnKvartovi.Location = new System.Drawing.Point(120, 87);
            this.btnKvartovi.Name = "btnKvartovi";
            this.btnKvartovi.Size = new System.Drawing.Size(199, 58);
            this.btnKvartovi.TabIndex = 4;
            this.btnKvartovi.Text = "Kvartovi";
            this.btnKvartovi.UseVisualStyleBackColor = true;
            this.btnKvartovi.Click += new System.EventHandler(this.btnKvartovi_Click);
            // 
            // btnLica
            // 
            this.btnLica.Location = new System.Drawing.Point(119, 380);
            this.btnLica.Name = "btnLica";
            this.btnLica.Size = new System.Drawing.Size(199, 73);
            this.btnLica.TabIndex = 5;
            this.btnLica.Text = "Lica";
            this.btnLica.UseVisualStyleBackColor = true;
            this.btnLica.Click += new System.EventHandler(this.btnLica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 567);
            this.Controls.Add(this.btnLica);
            this.Controls.Add(this.btnKvartovi);
            this.Controls.Add(this.btnPoslovnice);
            this.Controls.Add(this.btnUgovori);
            this.Controls.Add(this.btnNekretnine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNekretnine;
        private System.Windows.Forms.Button btnUgovori;
        private System.Windows.Forms.Button btnPoslovnice;
        private System.Windows.Forms.Button btnKvartovi;
        private System.Windows.Forms.Button btnLica;
    }
}

