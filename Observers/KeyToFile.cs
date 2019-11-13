using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Observers
{
    public class KeyToFile : IObserver
    {
        private string filename;

        public KeyToFile(string fname)
        {
            // criar/usar ficheiro no Desktop
            // filename = Path.Combine(
            // Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            //     "ex3_escreverTexto.txt");
            filename = fname;
        }

        public void Update(ISubject subject)
        {
            File.AppendAllText(
                filename, 
                (subject as KeyReader).LastKeyPressed.ToString());
        }
    }
}
