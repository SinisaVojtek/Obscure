using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Obscure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btKreirajFolder_Click(object sender, EventArgs e)
        {

            HidenFolder H = new HidenFolder();
            PathCheck PT = new PathCheck();
            StringBuilder ST = new StringBuilder();

            ST.Append(lblLokacija.Text);
            ST.Append("\\");

            if (PT.checkThePath(ST.ToString()) == true)
            {
                H.createHiddenFolder(ST.ToString());
            }
            else
            {
                MessageBox.Show("Neispravna putanja. Odaberite postojeći ili kreirajte novi folder.", "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPrikaziSkriveneFoldere_Click(object sender, EventArgs e)
        {
            gbKreirajSkriveniFolder.Visible = false;
            gbPopisDatoteka.Visible = false;
            gbPopisSkrivenihFoldera.Visible = true;
        }

        private void btKreirajSkriveniFolder_Click(object sender, EventArgs e)
        {
            gbKreirajSkriveniFolder.Visible = true;
            gbPopisDatoteka.Visible = false;
            gbPopisSkrivenihFoldera.Visible = false;
        }

        private void btPrikaziSkriveniFolder_Click(object sender, EventArgs e)
        {
            if (gbPopisSkrivenihFoldera.Visible == true)
            {
                foreach (DataGridViewCell cell in dgView1.SelectedCells)
                {
                    ShowFolder SH = new ShowFolder();
                    SH.showFolder(cell.Value.ToString());
                    MessageBox.Show(String.Format("Folder: {0} više nije sakriven.", cell.Value.ToString()), "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnPretraži_Click(sender, e);
                }
            }
            else
            {
                btPrikaziSkriveneFoldere_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowser FB = new FolderBrowser();
            lblLokacija.Text = FB.folderBrowser();
        }

        private void btnLokacijaPretrage_Click(object sender, EventArgs e)
        {
            FolderBrowser FB = new FolderBrowser();
            lblLokacijaSkrivenihFoldera.Text = FB.folderBrowser(); ;
        }

        private void btnPretraži_Click(object sender, EventArgs e)
        {
            if (lblLokacijaSkrivenihFoldera.Text == "")
                MessageBox.Show("Niste odabrali lokaciju pretrage.", "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                SearchHiddenFolders S = new SearchHiddenFolders();

                if (S.searchForHiddenFolders(lblLokacijaSkrivenihFoldera.Text).Count() == 0)
                {
                    MessageBox.Show("Na navedenoj lokaciji ne postoji niti jedan skriveni folder", "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgView1.DataSource = null;
                    lblNum1.Text = "0";
                }
                else
                {
                    FillDataGrid FD = new FillDataGrid();
                    FD.fillDataGridWithData(S.searchForHiddenFolders(lblLokacijaSkrivenihFoldera.Text), dgView1);

                }
            }
        }

        private void btnObrisiFolder_Click(object sender, EventArgs e)
        {
            DeleteFolder D = new DeleteFolder();

            try
            {
                if (gbPopisSkrivenihFoldera.Visible == true)
                {
                    foreach (DataGridViewCell cell in dgView1.SelectedCells)
                    {
                        D.deleteFolder(cell.Value.ToString());
                        btnPretraži_Click(sender, e);
                    }
                }
                else
                {
                    btPrikaziSkriveneFoldere_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Došlo je do pogreške: {0}", ex), "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSadrzajSkrivenogFoldera_Click(object sender, EventArgs e)
        {
            gbKreirajSkriveniFolder.Visible = false;
            gbPopisDatoteka.Visible = true;
            gbPopisSkrivenihFoldera.Visible = false;

            SearchFiles SF = new SearchFiles();
            List<string> files = new List<string>();
       
            FillDataGrid FD = new FillDataGrid();

            try
            {
                foreach (DataGridViewCell cell in dgView1.SelectedCells)
                {
                    files = SF.showFiles(cell.Value.ToString(), files);
                    if (files.Count() < 1)
                    {
                        MessageBox.Show("Odabrani folder ne sadrži niti jednu datoteku.", "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        FD.fillDataGridWithData(files, dgView2);
                    }
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Došlo je do pogreške: {0}", ex), "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}
       
        private void dgView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblNum1.Text = dgView1.RowCount.ToString();
        }

        private void dgView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblNum2.Text = dgView2.RowCount.ToString();
        }

        private void lblQuestionMark_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite lokaciju na kojoj želite kreirati folder ili odaberite postojeći folder.", "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
