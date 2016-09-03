using System;
using System.Collections.Generic;
using System.Text;

namespace MakeScript
{
    class MakeScriptSourceFile
    {
        public string FilePath;
        public bool FileExist;
    }

    class MakeScriptFile
    {
        public List<MakeScriptSourceFile> Files;
        public Dictionary<string, string> Parameters;
    }
}
