using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignpattern
{
    interface FileOps
    {
        public void WriteFile(string filePath, List<string> Data);
        public List<string> ReadFile(string filePath);
    }
}
