using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Obscure
{
    public class HidenFolder
    {
        /*Klasa mijenja atribut odabranog foldera u Hidden (sakriva folder)*/
        public void createHiddenFolder(string path){
           
                DialogResult DR=MessageBox.Show("Jeste li sigurni da želite sakriti odabrani folder?", "Obscure", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    if (!Directory.Exists(path))
                    {
                        MessageBox.Show("Neispravna putanja!", "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                       else
                    {
                        DirectoryInfo D = new DirectoryInfo(path);
                        D.Attributes |= FileAttributes.Hidden;
                        MessageBox.Show("Traženi folder je sakriven.", "Obscure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }                 
    }

    /*Klasa mijenja atribut foldera u Normal (folder više nije sakriven)*/
    public class ShowFolder {

        public void showFolder(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo D = new DirectoryInfo(path);
                D.Attributes = FileAttributes.Normal;
            }
            else
                MessageBox.Show("Folder ne postoji");
        }

    }

    /*Klasa zadužena za pretragu sadržaja foldera u potrazi za datotekama. Prolazi rekurzivno sadržaj foldera i 
      izbacuje broj datoteka unutar foldera i svih podfoldera zajedno.*/

    public class SearchFiles
    {
        public List<string> showFiles(string path, List<string>files)
        {         
            foreach (string file in Directory.GetFiles(path, "*.*"))
            {
                string extension = Path.GetExtension(file);

                if (extension != null)
                    files.Add(file);
            }

            foreach (string dir in Directory.GetDirectories(path))
                showFiles(dir,files);

            return files;
        }
    }

    /*Klasa zadužena za pretragu skrivenih foldera unutar odabrane lokacije.*/

    public class SearchHiddenFolders
    {
        public List<string> searchForHiddenFolders(string path)
        {
            List<string> folders = new List<string>();

            foreach (string folder in Directory.GetDirectories(path))
            {
                DirectoryInfo D = new DirectoryInfo(folder);
                if (D.Attributes.HasFlag(FileAttributes.Hidden))
                {
                        folders.Add(folder);
                }

            }

            return folders;
        }
    }

    /*Klasa zadužena za provjeru ispravnosti zadane putanje. U početku nisam koristio FolderBrowserDialog
     već se putanja unosila ručno pa je bilo smisleno provjeravati putanju. Nakon implementacije FolderBrowser klase
     to više nije nužno ali neka ostane kao dodatni nivo zaštite.*/

    class PathCheck
    {
        public bool checkThePath(string path)
        {
            Regex checkPath=new Regex(@"^[a-zA-Z]:\\$");

            if (string.IsNullOrWhiteSpace(path) || path.Length < 3)
                return false;

            if (!checkPath.IsMatch(path.Substring(0, 3)))
                return false;

            var str = (path.Substring(3, path.Length - 3));
            string invalidChars = new string(Path.GetInvalidPathChars());
            invalidChars+= @":?*";
            Regex hasInvalidChar = new Regex("[" + Regex.Escape(invalidChars) + "]");

            if (hasInvalidChar.IsMatch(path.Substring(3, path.Length - 3)))
                return false;

            var driveLetter = Path.GetPathRoot(path);

            if (!DriveInfo.GetDrives().Any(x => x.Name == driveLetter))
            {
                return false;
            }

            return true;

        }

    }

    /*Klasa omogućava pretragu podatkovnog sustava i odabir lokacije kao i kreiranje novih foldera
     na željenim lokacijama.*/

    public class FolderBrowser
    {
        public string folderBrowser()
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder st = new StringBuilder();
                    st.Append(folderDialog.SelectedPath.ToString());
                    st.Append("\\");
                    return st.ToString();
                }

                return string.Empty;
            }
        }
    }

    /*Klasa zadužena za brisanje foldera i podataka unutar foldera.*/

    public class DeleteFolder
    {
        public void deleteFolder(string path)
        {
            DialogResult DR = MessageBox.Show(String.Format("Jeste li sigurni da želite obrisati folder {0} ??", path), "Obscure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                SearchFiles SR = new Obscure.SearchFiles();
                List<string> list = new List<string>();

                if (SR.showFiles(path, list).Count() != 0)
                {
                    DialogResult DR2 = MessageBox.Show("Odabrani folder nije prazan, želite li obrisati sav sadržaj?", "Obscure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DR2 == DialogResult.Yes)
                    {
                        Directory.Delete(path, true);
                        MessageBox.Show("Odabrani folder i sav njegov sadržaj su obrisani.","Obscure", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Directory.Delete(path,true);
                    MessageBox.Show("Odabrani folder je obrisan.","Obscure",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else { }
        }
    }

    /*Klasa zadužena za popunjavanje GridView elemenata. Pošto ih u aplikaciji imamo dva, da bi izbjegli ponavljanje 
     koda izdvojili smo funkcionalnost u zasebnu klasu.*/

    public class FillDataGrid
    {
        public void fillDataGridWithData(List<string> list, DataGridView DG)
        {
            var popis = (from p in list select new { Text = p }).ToList();
            DG.DataSource = popis;
            DataGridViewColumn column = DG.Columns[0];
            column.Width = 300;
        }

    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
