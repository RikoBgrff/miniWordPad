using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniWordPad
{
    class FileHelper
    {
        public string fileName { get; set; }
        public string ReadFromFile()
        {
            var opener = new OpenFileDialog();
            opener.Filter = "Txt Files (*.txt)| *.txt";

            if (opener.ShowDialog() != true)
                return String.Empty;

            fileName = opener.FileName;

            return File.ReadAllText(fileName);
        }

        public void SaveToFile(string data)
        {
            var saver = new SaveFileDialog();

            saver.Filter = "Txt Files (*.txt)| *.txt";

            if (saver.ShowDialog() != true)
                return;

            fileName = GetFilePath(saver.FileName);

            File.WriteAllText(fileName, data);
        }

        public void AutoSave(string data)
        {
            if (String.IsNullOrWhiteSpace(fileName))
            {
                return;
            }
            File.WriteAllText(fileName, data);
        }
        private string GetFilePath(string filePath)
        {
            return filePath.EndsWith(".txt") ? filePath : filePath + ".txt";
        }
    }

}
