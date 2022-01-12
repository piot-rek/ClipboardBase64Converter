using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardBase64Converter
{
    public static class CbrdConverter
    {
        public static void ToBase64(string filename)
        {
            using (var filedata = File.OpenRead(filename))
            {

                //if (filedata.Length > (20L * 1024 *1024*1024))
                //if (!(MessageBox.Show("Plik ma rozmiar " + (filedata.Length / 1024 / 1024 / 1024).ToString() + "MB. Konwersja może zająć dużo czasu. Czy na pewno wykonać?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes) )return;
                byte[] buffer = new byte[filedata.Length];
                filedata.Read(buffer, 0, (int)filedata.Length);
                Clipboard.SetText(Convert.ToBase64String(buffer, Base64FormattingOptions.None));
            }
        }
        public static void FromBase64(string foldername)
        {
            try
            {
                var basetext = Clipboard.GetText();
                var result = Convert.FromBase64String(basetext);
                var sfd = new SaveFileDialog();
                if (foldername != null) sfd.InitialDirectory = foldername;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var file = File.Create(sfd.FileName))
                    {
                        file.Write(result, 0, result.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }
    }
}
