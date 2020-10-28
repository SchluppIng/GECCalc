using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Using export to word from reference is needed
using exporttoword = Microsoft.Office.Interop.Word;

namespace Output
{
    class WordExport
    {
        string path;
        string rtResults;
        public WordExport(string filePath, string richTextboxResults)
        {
            rtResults = richTextboxResults;
            path = filePath;
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(rtResults);
            sw.Close();
        }
    }
}
