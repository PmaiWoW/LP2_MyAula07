using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Observers_Push
{
    public class KeyToFile : IObserver<ConsoleKey>
    {
        private string filename;

        public KeyToFile(string fname)
        {
            // criar/usar ficheiro no Desktop
            filename = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Aula07_ex1_5.txt");
        }

        public void Update(ConsoleKey key)
        {
            File.AppendAllText(filename,  key.ToString());
        }
    }
}
