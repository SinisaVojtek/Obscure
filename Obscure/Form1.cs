using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obscure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite lokaciju na kojoj želite kreirati vaš skriveni folder.", "Obscure", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void btKreirajFolder_Click(object sender, EventArgs e)
        {

                HidenFolder H = new HidenFolder();
                PathCheck PT = new PathCheck();
                StringBuilder ST = new StringBuilder();

                ST.Append(lblLokacija.Text);
                ST.Append(tbNazivFoldera.Text);
                ST.Append("\\");

                if (PT.checkThePath(ST.ToString()) == true)
                {
                    H.createHiddenFolder(ST.ToString());
                }
                else
                {
                    MessageBox.Show("Neispravno kreirana putanja. Koristite ispravno ime i ispravnu putanju.", "Obscure", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            foreach (DataGridViewCell cell in dgView1.SelectedCells)
            {
                ShowFolder SH = new ShowFolder();
                SH.showFolder(cell.Value.ToString());   
                MessageBox.Show(String.Format("Folder: {0} više nije sakriven.", cell.Value.ToString()), "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowser FB = new Obscure.FolderBrowser();
            lblLokacija.Text = FB.folderBrowser();
        }

        public void btnLokacijaPretrage_Click(object sender, EventArgs e)
        {
            FolderBrowser FB = new FolderBrowser();
            lblLokacijaSkrivenihFoldera.Text = FB.folderBrowser(); ;
        }

        private void btnPretraži_Click(object sender, EventArgs e)
        {
            SearchHiddenFolders S = new SearchHiddenFolders();

            if (S.searchForHiddenFolders(lblLokacijaSkrivenihFoldera.Text).Count() == 0)
            {
                MessageBox.Show("Na navedenoj lokaciji ne postoji niti jedan skriveni folder", "Obscure", MessageBoxButtons.OK);
            }
            else
            {
                FillDataGrid FD = new FillDataGrid();
                FD.fillDataGridWithData(S.searchForHiddenFolders(lblLokacijaSkrivenihFoldera.Text), dgView1);

            }
        }

        private void btnObrisiFolder_Click(object sender, EventArgs e)
        {
            DeleteFolder D = new DeleteFolder();

            foreach (DataGridViewCell cell in dgView1.SelectedCells)
            {
                D.deleteFolder(cell.Value.ToString());
                btnPretraži_Click(sender, e);
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

            foreach (DataGridViewCell cell in dgView1.SelectedCells)
            {
                FD.fillDataGridWithData(SF.showFiles(cell.Value.ToString(), files), dgView2);
            }

        }
    }
}
