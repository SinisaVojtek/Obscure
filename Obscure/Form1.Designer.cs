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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.gbPopisSkrivenihFoldera = new System.Windows.Forms.GroupBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblCountFolders = new System.Windows.Forms.Label();
            this.btnPretraži = new System.Windows.Forms.Button();
            this.btnLokacijaPretrage = new System.Windows.Forms.Button();
            this.lblLokacijaSkrivenihFoldera = new System.Windows.Forms.Label();
            this.dgView1 = new System.Windows.Forms.DataGridView();
            this.gbPopisDatoteka = new System.Windows.Forms.GroupBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.dgView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbKreirajSkriveniFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPopisSkrivenihFoldera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView1)).BeginInit();
            this.gbPopisDatoteka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btKreirajSkriveniFolder
            // 
            this.btKreirajSkriveniFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btKreirajSkriveniFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btKreirajSkriveniFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKreirajSkriveniFolder.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKreirajSkriveniFolder.ForeColor = System.Drawing.Color.Cornsilk;
            this.btKreirajSkriveniFolder.Location = new System.Drawing.Point(-1, 0);
            this.btKreirajSkriveniFolder.Name = "btKreirajSkriveniFolder";
            this.btKreirajSkriveniFolder.Size = new System.Drawing.Size(163, 60);
            this.btKreirajSkriveniFolder.TabIndex = 0;
            this.btKreirajSkriveniFolder.Text = "Kreiraj skriveni folder";
            this.btKreirajSkriveniFolder.UseVisualStyleBackColor = true;
            this.btKreirajSkriveniFolder.Click += new System.EventHandler(this.btKreirajSkriveniFolder_Click);
            // 
            // btPrikaziSkriveniFolder
            // 
            this.btPrikaziSkriveniFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btPrikaziSkriveniFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btPrikaziSkriveniFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrikaziSkriveniFolder.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrikaziSkriveniFolder.ForeColor = System.Drawing.Color.Cornsilk;
            this.btPrikaziSkriveniFolder.Location = new System.Drawing.Point(-1, 118);
            this.btPrikaziSkriveniFolder.Name = "btPrikaziSkriveniFolder";
            this.btPrikaziSkriveniFolder.Size = new System.Drawing.Size(163, 60);
            this.btPrikaziSkriveniFolder.TabIndex = 1;
            this.btPrikaziSkriveniFolder.Text = "Prikaži skriveni folder";
            this.btPrikaziSkriveniFolder.UseVisualStyleBackColor = true;
            this.btPrikaziSkriveniFolder.Click += new System.EventHandler(this.btPrikaziSkriveniFolder_Click);
            // 
            // btPopisSkrivenihFoldera
            // 
            this.btPopisSkrivenihFoldera.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btPopisSkrivenihFoldera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btPopisSkrivenihFoldera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPopisSkrivenihFoldera.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPopisSkrivenihFoldera.ForeColor = System.Drawing.Color.Cornsilk;
            this.btPopisSkrivenihFoldera.Location = new System.Drawing.Point(-1, 59);
            this.btPopisSkrivenihFoldera.Name = "btPopisSkrivenihFoldera";
            this.btPopisSkrivenihFoldera.Size = new System.Drawing.Size(163, 60);
            this.btPopisSkrivenihFoldera.TabIndex = 2;
            this.btPopisSkrivenihFoldera.Text = "popis skrivenih foldera";
            this.btPopisSkrivenihFoldera.UseVisualStyleBackColor = true;
            this.btPopisSkrivenihFoldera.Click += new System.EventHandler(this.btPrikaziSkriveneFoldere_Click);
            // 
            // btSadrzajSkrivenogFoldera
            // 
            this.btSadrzajSkrivenogFoldera.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btSadrzajSkrivenogFoldera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btSadrzajSkrivenogFoldera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSadrzajSkrivenogFoldera.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSadrzajSkrivenogFoldera.ForeColor = System.Drawing.Color.Cornsilk;
            this.btSadrzajSkrivenogFoldera.Location = new System.Drawing.Point(-1, 236);
            this.btSadrzajSkrivenogFoldera.Name = "btSadrzajSkrivenogFoldera";
            this.btSadrzajSkrivenogFoldera.Size = new System.Drawing.Size(163, 60);
            this.btSadrzajSkrivenogFoldera.TabIndex = 3;
            this.btSadrzajSkrivenogFoldera.Text = "popis datoteka skrivenog foldera";
            this.btSadrzajSkrivenogFoldera.UseVisualStyleBackColor = true;
            this.btSadrzajSkrivenogFoldera.Click += new System.EventHandler(this.btSadrzajSkrivenogFoldera_Click);
            // 
            // btnObrisiFolder
            // 
            this.btnObrisiFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnObrisiFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnObrisiFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiFolder.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiFolder.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnObrisiFolder.Location = new System.Drawing.Point(-1, 177);
            this.btnObrisiFolder.Name = "btnObrisiFolder";
            this.btnObrisiFolder.Size = new System.Drawing.Size(163, 60);
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
            this.gbKreirajSkriveniFolder.Location = new System.Drawing.Point(24, 19);
            this.gbKreirajSkriveniFolder.Name = "gbKreirajSkriveniFolder";
            this.gbKreirajSkriveniFolder.Size = new System.Drawing.Size(420, 262);
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
            this.btKreirajFolder.Location = new System.Drawing.Point(13, 144);
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
            // gbPopisSkrivenihFoldera
            // 
            this.gbPopisSkrivenihFoldera.Controls.Add(this.lblNum1);
            this.gbPopisSkrivenihFoldera.Controls.Add(this.lblCountFolders);
            this.gbPopisSkrivenihFoldera.Controls.Add(this.btnPretraži);
            this.gbPopisSkrivenihFoldera.Controls.Add(this.btnLokacijaPretrage);
            this.gbPopisSkrivenihFoldera.Controls.Add(this.lblLokacijaSkrivenihFoldera);
            this.gbPopisSkrivenihFoldera.Controls.Add(this.dgView1);
            this.gbPopisSkrivenihFoldera.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPopisSkrivenihFoldera.Location = new System.Drawing.Point(24, 15);
            this.gbPopisSkrivenihFoldera.Name = "gbPopisSkrivenihFoldera";
            this.gbPopisSkrivenihFoldera.Size = new System.Drawing.Size(420, 262);
            this.gbPopisSkrivenihFoldera.TabIndex = 4;
            this.gbPopisSkrivenihFoldera.TabStop = false;
            this.gbPopisSkrivenihFoldera.Text = "Popis skrivenih foldera";
            this.gbPopisSkrivenihFoldera.Visible = false;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Consolas", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(306, 115);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(79, 88);
            this.lblNum1.TabIndex = 5;
            this.lblNum1.Text = "0";
            // 
            // lblCountFolders
            // 
            this.lblCountFolders.AutoSize = true;
            this.lblCountFolders.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountFolders.Location = new System.Drawing.Point(269, 90);
            this.lblCountFolders.Name = "lblCountFolders";
            this.lblCountFolders.Size = new System.Drawing.Size(145, 13);
            this.lblCountFolders.TabIndex = 4;
            this.lblCountFolders.Text = "Broj skrivenih foldera:";
            // 
            // btnPretraži
            // 
            this.btnPretraži.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraži.Location = new System.Drawing.Point(6, 52);
            this.btnPretraži.Name = "btnPretraži";
            this.btnPretraži.Size = new System.Drawing.Size(120, 23);
            this.btnPretraži.TabIndex = 3;
            this.btnPretraži.Text = "Pretraži lokaciju";
            this.btnPretraži.UseVisualStyleBackColor = true;
            this.btnPretraži.Click += new System.EventHandler(this.btnPretraži_Click);
            // 
            // btnLokacijaPretrage
            // 
            this.btnLokacijaPretrage.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLokacijaPretrage.Location = new System.Drawing.Point(6, 22);
            this.btnLokacijaPretrage.Name = "btnLokacijaPretrage";
            this.btnLokacijaPretrage.Size = new System.Drawing.Size(120, 23);
            this.btnLokacijaPretrage.TabIndex = 2;
            this.btnLokacijaPretrage.Text = "Lokacija pretrage";
            this.btnLokacijaPretrage.UseVisualStyleBackColor = true;
            this.btnLokacijaPretrage.Click += new System.EventHandler(this.btnLokacijaPretrage_Click);
            // 
            // lblLokacijaSkrivenihFoldera
            // 
            this.lblLokacijaSkrivenihFoldera.AutoSize = true;
            this.lblLokacijaSkrivenihFoldera.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacijaSkrivenihFoldera.Location = new System.Drawing.Point(133, 27);
            this.lblLokacijaSkrivenihFoldera.Name = "lblLokacijaSkrivenihFoldera";
            this.lblLokacijaSkrivenihFoldera.Size = new System.Drawing.Size(19, 13);
            this.lblLokacijaSkrivenihFoldera.TabIndex = 1;
            this.lblLokacijaSkrivenihFoldera.Text = "xx";
            // 
            // dgView1
            // 
            this.dgView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView1.Location = new System.Drawing.Point(3, 90);
            this.dgView1.Name = "dgView1";
            this.dgView1.Size = new System.Drawing.Size(261, 169);
            this.dgView1.TabIndex = 0;
            this.dgView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgView1_DataBindingComplete);
            // 
            // gbPopisDatoteka
            // 
            this.gbPopisDatoteka.Controls.Add(this.lblNum2);
            this.gbPopisDatoteka.Controls.Add(this.lblFileCount);
            this.gbPopisDatoteka.Controls.Add(this.dgView2);
            this.gbPopisDatoteka.Location = new System.Drawing.Point(24, 15);
            this.gbPopisDatoteka.Name = "gbPopisDatoteka";
            this.gbPopisDatoteka.Size = new System.Drawing.Size(420, 266);
            this.gbPopisDatoteka.TabIndex = 1;
            this.gbPopisDatoteka.TabStop = false;
            this.gbPopisDatoteka.Text = "Popis datoteka";
            this.gbPopisDatoteka.Visible = false;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Consolas", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(326, 41);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(79, 88);
            this.lblNum2.TabIndex = 9;
            this.lblNum2.Text = "0";
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileCount.Location = new System.Drawing.Point(320, 16);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(91, 13);
            this.lblFileCount.TabIndex = 8;
            this.lblFileCount.Text = "Broj datoteka:";
            // 
            // dgView2
            // 
            this.dgView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView2.Location = new System.Drawing.Point(3, 16);
            this.dgView2.Name = "dgView2";
            this.dgView2.Size = new System.Drawing.Size(309, 243);
            this.dgView2.TabIndex = 0;
            this.dgView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgView2_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.gbPopisDatoteka);
            this.panel1.Controls.Add(this.gbPopisSkrivenihFoldera);
            this.panel1.Controls.Add(this.gbKreirajSkriveniFolder);
            this.panel1.Location = new System.Drawing.Point(158, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 296);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(635, 295);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSadrzajSkrivenogFoldera);
            this.Controls.Add(this.btPopisSkrivenihFoldera);
            this.Controls.Add(this.btnObrisiFolder);
            this.Controls.Add(this.btPrikaziSkriveniFolder);
            this.Controls.Add(this.btKreirajSkriveniFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Obscure";
            this.gbKreirajSkriveniFolder.ResumeLayout(false);
            this.gbKreirajSkriveniFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPopisSkrivenihFoldera.ResumeLayout(false);
            this.gbPopisSkrivenihFoldera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView1)).EndInit();
            this.gbPopisDatoteka.ResumeLayout(false);
            this.gbPopisDatoteka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView2)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblCountFolders;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Panel panel1;
    }
}

