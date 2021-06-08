using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AbstractFactoryDesignpattern
{
    class txtFileOps : FileOps
    {
        
        public void WriteFile(string filePath, List<string> Data)
        {
            
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            Data.ForEach(x => sw.WriteLine(x) );
           // sw.WriteLine("");
            //sw.WriteLine("");

            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public List<string> ReadFile(string filePath)
        {
            
            List<string> lines = new List<string>();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            while (line != null)
            {
                lines.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
            return lines;
        }

    }
}
