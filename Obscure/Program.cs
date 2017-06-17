using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obscure
{
    public class HidenFolder
    {
        public void createHiddenFolder(string path){
            if (!Directory.Exists(path))
            {
                DirectoryInfo D = new DirectoryInfo(path);
                D.Create();
                D.Attributes |= FileAttributes.Hidden;
                MessageBox.Show(String.Format("Kreirali ste novi skriveni folder na lokaciji: {0}", path));
            }
            else
            {
                DialogResult DR=MessageBox.Show("Folder sa tim imenom već postoji na toj lokaciji. Želite li ga sakriti", "Obscure", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    DirectoryInfo D = new DirectoryInfo(path);
                    D.Attributes |= FileAttributes.Hidden;
                    MessageBox.Show("Traženi folder je sakriven.");
                }
                else { }

            }            
        }      
    }

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

    public class DeleteFolder
    {
        public void deleteFolder(string path)
        {
            DialogResult DR = MessageBox.Show(String.Format("Jeste li sigurni da želite obrisati folder {0} ??", path), "Obscure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Directory.Delete(path);
                MessageBox.Show("Odabrani folder je obrisan.");
            }
            else { }
        }

    }

    public class FillDataGrid
    {
        public void fillDataGridWithData(List<string> list, DataGridView DG)
        {
            var popis = (from p in list select new { Text = p }).ToList();
            DG.DataSource = popis;
            DataGridViewColumn column = DG.Columns[0];
            column.Width = 250;
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
