using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace MakeScript
{
    class MakeScriptBuilder
    {
        private List<string> files;
        private string target;

        public MakeScriptBuilder(List<string> sourecFileList, string targetFile)
        {
            files = new List<string>();

            files = sourecFileList;
            target = targetFile;
        }

        public MakeScriptBuilder(string sourceFile, string targetFile)
        {
            files = new List<string>();

            files.Add(sourceFile);
            target = targetFile;
        }

        public void Build()
        {
            File.WriteAllLines(target, files.SelectMany(File.ReadLines));
        }
    }
}
