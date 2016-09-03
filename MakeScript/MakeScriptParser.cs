using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace MakeScript
{
    class MakeScriptParser
    {
        private List<string> files;
        private Dictionary<string, string> parameters;
        private const string parametersPattern  = @"^\s*?(?<key>\w+?)\s*?=\s*?[""'](?<value>[\w:\.\\:\-\s]*)[""']\s*?$";
        private const string filesPattern       = @"^\s*?(?<path>(?:\w:)??[\\/][\w\.\\/\s-]+?(?:\.\w+)??)\s*?$";
        private string scriptPath;
        private string startPath;
        private string outputFile;
        private string outputFileExtension;
        private string outputFileExtensionDefaul = "sql";
        private string outputPath;
        private int filesCount;        

        #region Constructors
        public MakeScriptParser()
        {
            files = new List<string>();
            parameters = new Dictionary<string, string>();
        }

        public MakeScriptParser(string makeScriptFile) : this()
        {
            scriptPath = makeScriptFile;
        }
        #endregion

        private void ParseParameters (string text)
        {
            MatchCollection mcParameters = Regex.Matches(text, parametersPattern, RegexOptions.Multiline);

            foreach (Match m in mcParameters)
            {
                parameters.Add(m.Groups["key"].Value, m.Groups["value"].Value);
            }
        }

        private void ParseFiles(string text)
        {
            MatchCollection mcFiles = Regex.Matches(text, filesPattern, RegexOptions.Multiline);

            foreach (Match m in mcFiles)
            {
                files.Add(m.Groups["path"].Value.Trim());
            }
            
            filesCount = files.Count;
            if (filesCount > 0)
                outputFileExtension = Path.GetExtension(files[0]);
        }

        private void AssignParameters (Dictionary<string, string> p)
        {
            if (p.ContainsKey("StartPath"))
                startPath = Path.GetDirectoryName(p["StartPath"]);
            else
                if (scriptPath != null && scriptPath.Length > 0)
                    startPath = Path.GetDirectoryName(scriptPath);
                else
                    startPath = "";

            if (!startPath.EndsWith("\\") && startPath != "")
                startPath = startPath + "\\";

            if (p.ContainsKey("OutputFile"))
                outputFile = p["OutputFile"];
            else
                outputFile = Path.GetFileNameWithoutExtension(scriptPath) + "_Script" + outputFileExtension ?? outputFileExtensionDefaul;

            if (p.ContainsKey("OutptPath"))
                outputPath = p["OutptPath"];
            else
                outputPath = startPath;

            if (!outputPath.EndsWith("\\") && outputPath != "")
                outputPath = outputPath + "\\";
        }

        private string NormalizePath(string startPath, string path)
        {
            string normalizedPath;
            StringBuilder sb = new StringBuilder();

            if (path.StartsWith("\\") || path.StartsWith("/"))
                normalizedPath = sb.Append(startPath).Append(path).Replace('/', '\\').Replace("\\\\", "\\").ToString(); 
            else
                normalizedPath = sb.Append(path).Replace('/', '\\').Replace("\\\\", "\\").ToString();

            sb.Clear();
            return (normalizedPath);
        }

        private void NormalizeFiles(List<string> fileList)
        {
            for (int i = 0; i < fileList.Count; i++)
            {
                fileList[i] = NormalizePath(startPath, fileList[i]);
            }
        }

        public void Parse (string text)
        {
            ParseParameters(text);

            ParseFiles(text);

            AssignParameters(parameters);

            NormalizeFiles(files);
        }

        #region Properties
        public string StartPath
        {
            get { return (startPath); }
        }

        public string OutputFile
        {
            get { return (outputFile); }
        }

        public string OutputPath
        {
            get { return (outputPath); }
        }

        public string OutputPathFile
        {
            get { return (outputPath + outputFile); }
        }

        public List<string> Files
        {
            get { return (files); }
        }

        public int FilesCount
        {
            get { return (filesCount); }
        } 
        #endregion
    }
}
