using System.Collections.Generic;
using System.IO;

namespace Analitik
{
    // получает адрес папки

    // если больше одного файла возвращает
    // анализирует сколько файлов
    // анализирует сколько классов


    internal class DirAnaliz
    {
        private string path;
        private int txt_files;
        List<string> files_names;

        public DirAnaliz(string str)
        {
            this.path = str + "\\labels";

        }
        public string ChPath()
        {
            return path;
        }
        public int CountTxtFiles()
        {
            files_names = new List<string>();
            var dir_count = new DirectoryInfo(path);

            foreach (FileInfo file in dir_count.GetFiles("*.txt"))
            {
                files_names.Add(Path.GetFileName(file.FullName));
            }
            txt_files = files_names.Count;
            return txt_files;
        }

        public List<string> ListFileNames()
        {
            CountTxtFiles();
            return files_names;
        }
        public bool IsOne()
        {
            if (txt_files > 1)
            {
                return false;
            }
            return true;

        }

    }
}
