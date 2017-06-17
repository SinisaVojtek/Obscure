namespace Obscure
{
    partial class Form1
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
            this.btKreirajSkriveniFolder = new System.Windows.Forms.Button();
            this.btPrikaziSkriveniFolder = new System.Windows.Forms.Button();
            this.btPopisSkrivenihFoldera = new System.Windows.Forms.Button();
            this.btSadrzajSkrivenogFoldera = new System.Windows.Forms.Button();
            this.btnObrisiFolder = new System.Windows.Forms.Button();
            this.gbKreirajSkriveniFolder = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.btnOdabirFoldera = new System.Windows.Forms.Button();
            this.btKreirajFolder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNazivFoldera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPopisSkrivenihFoldera = new System.Windows.Forms.GroupBox();
            this.btnPretraži = new System.Windows.Forms.Button();
            this.btnLokacijaPretrage = new System.Windows.Forms.Button();
            this.lblLokacijaSkrivenihFoldera = new System.Windows.Forms.Label();
            this.dgView1 = new System.Windows.Forms.DataGridView();
            this.gbPopisDatoteka = new System.Windows.Forms.GroupBox();
            this.dgView2 = new System.Windows.Forms.DataGridView();
            this.gbKreirajSkriveniFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPopisSkrivenihFoldera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView1)).BeginInit();
            this.gbPopisDatoteka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btKreirajSkriveniFolder
            // 
            this.btKreirajSkriveniFolder.Location = new System.Drawing.Point(12, 12);
            this.btKreirajSkriveniFolder.Name = "btKreirajSkriveniFolder";
            this.btKreirajSkriveniFolder.Size = new System.Drawing.Size(128, 48);
            this.btKreirajSkriveniFolder.TabIndex = 0;
            this.btKreirajSkriveniFolder.Text = "Kreiraj skriveni folder";
            this.btKreirajSkriveniFolder.UseVisualStyleBackColor = true;
            this.btKreirajSkriveniFolder.Click += new System.EventHandler(this.btKreirajSkriveniFolder_Click);
            // 
            // btPrikaziSkriveniFolder
            // 
            this.btPrikaziSkriveniFolder.Location = new System.Drawing.Point(12, 120);
            this.btPrikaziSkriveniFolder.Name = "btPrikaziSkriveniFolder";
            this.btPrikaziSkriveniFolder.Size = new System.Drawing.Size(128, 48);
            this.btPrikaziSkriveniFolder.TabIndex = 1;
            this.btPrikaziSkriveniFolder.Text = "Prikaži skriveni folder";
            this.btPrikaziSkriveniFolder.UseVisualStyleBackColor = true;
            this.btPrikaziSkriveniFolder.Click += new System.EventHandler(this.btPrikaziSkriveniFolder_Click);
            // 
            // btPopisSkrivenihFoldera
            // 
            this.btPopisSkrivenihFoldera.Location = new System.Drawing.Point(12, 66);
            this.btPopisSkrivenihFoldera.Name = "btPopisSkrivenihFoldera";
            this.btPopisSkrivenihFoldera.Size = new System.Drawing.Size(128, 48);
            this.btPopisSkrivenihFoldera.TabIndex = 2;
            this.btPopisSkrivenihFoldera.Text = "popis skrivenih foldera";
            this.btPopisSkrivenihFoldera.UseVisualStyleBackColor = true;
            this.btPopisSkrivenihFoldera.Click += new System.EventHandler(this.btPrikaziSkriveneFoldere_Click);
            // 
            // btSadrzajSkrivenogFoldera
            // 
            this.btSadrzajSkrivenogFoldera.Location = new System.Drawing.Point(12, 225);
            this.btSadrzajSkrivenogFoldera.Name = "btSadrzajSkrivenogFoldera";
            this.btSadrzajSkrivenogFoldera.Size = new System.Drawing.Size(128, 48);
            this.btSadrzajSkrivenogFoldera.TabIndex = 3;
            this.btSadrzajSkrivenogFoldera.Text = "popis datoteka skrivenog foldera";
            this.btSadrzajSkrivenogFoldera.UseVisualStyleBackColor = true;
            this.btSadrzajSkrivenogFoldera.Click += new System.EventHandler(this.btSadrzajSkrivenogFoldera_Click);
            // 
            // btnObrisiFolder
            // 
            this.btnObrisiFolder.Location = new System.Drawing.Point(12, 171);
            this.btnObrisiFolder.Name = "btnObrisiFolder";
            this.btnObrisiFolder.Size = new System.Drawing.Size(128, 48);
            this.btnObrisiFolder.TabIndex = 4;
            this.btnObrisiFolder.Text = "Obriši skriveni folder";
            this.btnObrisiFolder.UseVisualStyleBackColor = true;
            this.btnObrisiFolder.Click += new System.EventHandler(this.btnObrisiFolder_Click);
            // 
            // gbKreirajSkriveniFolder
            // 
            this.gbKreirajSkriveniFolder.Controls.Add(this.label2);
            this.gbKreirajSkriveniFolder.Controls.Add(this.lblLokacija);
            this.gbKreirajSkriveniFolder.Controls.Add(this.btnOdabirFoldera);
            this.gbKreirajSkriveniFolder.Controls.Add(this.btKreirajFolder);
            this.gbKreirajSkriveniFolder.Controls.Add(this.pictureBox1);
            this.gbKreirajSkriveniFolder.Controls.Add(this.tbNazivFoldera);
            this.gbKreirajSkriveniFolder.Controls.Add(this.label1);
            this.gbKreirajSkriveniFolder.Location = new System.Drawing.Point(180, 14);
            this.gbKreirajSkriveniFolder.Name = "gbKreirajSkriveniFolder";
            this.gbKreirajSkriveniFolder.Size = new System.Drawing.Size(267, 262);
            this.gbKreirajSkriveniFolder.TabIndex = 5;
            this.gbKreirajSkriveniFolder.TabStop = false;
            this.gbKreirajSkriveniFolder.Text = "Kreiraj skriveni folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odabrana lokacija:";
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Location = new System.Drawing.Point(10, 95);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(0, 13);
            this.lblLokacija.TabIndex = 5;
            // 
            // btnOdabirFoldera
            // 
            this.btnOdabirFoldera.Location = new System.Drawing.Point(11, 35);
            this.btnOdabirFoldera.Name = "btnOdabirFoldera";
            this.btnOdabirFoldera.Size = new System.Drawing.Size(142, 23);
            this.btnOdabirFoldera.TabIndex = 4;
            this.btnOdabirFoldera.Text = "Odaberi lokaciju foldera";
            this.btnOdabirFoldera.UseVisualStyleBackColor = true;
            this.btnOdabirFoldera.Click += new System.EventHandler(this.button1_Click);
            // 
            // btKreirajFolder
            // 
            this.btKreirajFolder.Location = new System.Drawing.Point(11, 172);
            this.btKreirajFolder.Name = "btKreirajFolder";
            this.btKreirajFolder.Size = new System.Drawing.Size(75, 23);
            this.btKreirajFolder.TabIndex = 3;
            this.btKreirajFolder.Text = "Kreiraj folder";
            this.btKreirajFolder.UseVisualStyleBackColor = true;
            this.btKreirajFolder.Click += new System.EventHandler(this.btKreirajFolder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Obscure.Properties.Resources.question_mark;
            this.pictureBox1.Location = new System.Drawing.Point(159, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbNazivFoldera
            // 
            this.tbNazivFoldera.Location = new System.Drawing.Point(11, 146);
            this.tbNazivFoldera.Name = "tbNazivFoldera";
            this.tbNazivFoldera.Size = new System.Drawing.Size(143, 20);
            this.tbNazivFoldera.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upišite ime vašeg foldera:";
            // 
            // gbPopisSkrivenihFoldera
            // 
            this.gbPopisSkrivenihFoldera.Controls.Add(this.btnPretraži);
            this.gbPopisSkrivenihFoldera.Controls.Add(this.btnLokacijaPretrage);
            this.gbPopisSkrivenihFoldera.Controls.Add(this.lblLokacijaSkrivenihFoldera);
            this.gbPopisSkrivenihFoldera.Controls.Add(this.dgView1);
            this.gbPopisSkrivenihFoldera.Location = new System.Drawing.Point(180, 14);
            this.gbPopisSkrivenihFoldera.Name = "gbPopisSkrivenihFoldera";
            this.gbPopisSkrivenihFoldera.Size = new System.Drawing.Size(267, 262);
            this.gbPopisSkrivenihFoldera.TabIndex = 4;
            this.gbPopisSkrivenihFoldera.TabStop = false;
            this.gbPopisSkrivenihFoldera.Text = "Popis skrivenih foldera";
            this.gbPopisSkrivenihFoldera.Visible = false;
            // 
            // btnPretraži
            // 
            this.btnPretraži.Location = new System.Drawing.Point(6, 52);
            this.btnPretraži.Name = "btnPretraži";
            this.btnPretraži.Size = new System.Drawing.Size(100, 23);
            this.btnPretraži.TabIndex = 3;
            this.btnPretraži.Text = "Pretraži lokaciju";
            this.btnPretraži.UseVisualStyleBackColor = true;
            this.btnPretraži.Click += new System.EventHandler(this.btnPretraži_Click);
            // 
            // btnLokacijaPretrage
            // 
            this.btnLokacijaPretrage.Location = new System.Drawing.Point(6, 22);
            this.btnLokacijaPretrage.Name = "btnLokacijaPretrage";
            this.btnLokacijaPretrage.Size = new System.Drawing.Size(100, 23);
            this.btnLokacijaPretrage.TabIndex = 2;
            this.btnLokacijaPretrage.Text = "Lokacija pretrage";
            this.btnLokacijaPretrage.UseVisualStyleBackColor = true;
            this.btnLokacijaPretrage.Click += new System.EventHandler(this.btnLokacijaPretrage_Click);
            // 
            // lblLokacijaSkrivenihFoldera
            // 
            this.lblLokacijaSkrivenihFoldera.AutoSize = true;
            this.lblLokacijaSkrivenihFoldera.Location = new System.Drawing.Point(112, 32);
            this.lblLokacijaSkrivenihFoldera.Name = "lblLokacijaSkrivenihFoldera";
            this.lblLokacijaSkrivenihFoldera.Size = new System.Drawing.Size(57, 13);
            this.lblLokacijaSkrivenihFoldera.TabIndex = 1;
            this.lblLokacijaSkrivenihFoldera.Text = "xxxxxxxxxx";
            // 
            // dgView1
            // 
            this.dgView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView1.Location = new System.Drawing.Point(3, 90);
            this.dgView1.Name = "dgView1";
            this.dgView1.Size = new System.Drawing.Size(261, 169);
            this.dgView1.TabIndex = 0;
            // 
            // gbPopisDatoteka
            // 
            this.gbPopisDatoteka.Controls.Add(this.dgView2);
            this.gbPopisDatoteka.Location = new System.Drawing.Point(180, 14);
            this.gbPopisDatoteka.Name = "gbPopisDatoteka";
            this.gbPopisDatoteka.Size = new System.Drawing.Size(267, 262);
            this.gbPopisDatoteka.TabIndex = 1;
            this.gbPopisDatoteka.TabStop = false;
            this.gbPopisDatoteka.Text = "Popis datoteka";
            this.gbPopisDatoteka.Visible = false;
            // 
            // dgView2
            // 
            this.dgView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView2.Location = new System.Drawing.Point(3, 16);
            this.dgView2.Name = "dgView2";
            this.dgView2.Size = new System.Drawing.Size(261, 243);
            this.dgView2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 291);
            this.Controls.Add(this.btnObrisiFolder);
            this.Controls.Add(this.btSadrzajSkrivenogFoldera);
            this.Controls.Add(this.btPopisSkrivenihFoldera);
            this.Controls.Add(this.btPrikaziSkriveniFolder);
            this.Controls.Add(this.btKreirajSkriveniFolder);
            this.Controls.Add(this.gbPopisDatoteka);
            this.Controls.Add(this.gbPopisSkrivenihFoldera);
            this.Controls.Add(this.gbKreirajSkriveniFolder);
            this.Name = "Form1";
            this.Text = "Obscure";
            this.gbKreirajSkriveniFolder.ResumeLayout(false);
            this.gbKreirajSkriveniFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPopisSkrivenihFoldera.ResumeLayout(false);
            this.gbPopisSkrivenihFoldera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView1)).EndInit();
            this.gbPopisDatoteka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btKreirajSkriveniFolder;
        private System.Windows.Forms.Button btPrikaziSkriveniFolder;
        private System.Windows.Forms.Button btPopisSkrivenihFoldera;
        private System.Windows.Forms.Button btSadrzajSkrivenogFoldera;
        private System.Windows.Forms.Button btnObrisiFolder;
        private System.Windows.Forms.GroupBox gbKreirajSkriveniFolder;
        private System.Windows.Forms.Button btKreirajFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNazivFoldera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPopisSkrivenihFoldera;
        private System.Windows.Forms.GroupBox gbPopisDatoteka;
        private System.Windows.Forms.DataGridView dgView1;
        private System.Windows.Forms.Button btnOdabirFoldera;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLokacijaPretrage;
        private System.Windows.Forms.Label lblLokacijaSkrivenihFoldera;
        private System.Windows.Forms.Button btnPretraži;
        private System.Windows.Forms.DataGridView dgView2;
    }
}

