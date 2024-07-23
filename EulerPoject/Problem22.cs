using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    public class Problem22
    {
        public void Calculate()
        {
            var names = ReadNamesFile();

        }

        private List<string> ReadNamesFile()
        {
            var names = new List<string>(60_000);

            using StreamReader sr = new StreamReader("Resources\\Problem22\\0022_names.txt");
            int character;
            var sb = new StringBuilder();
            while((character = sr.Read()) != -1)
            {
                char c = (char)character;
                if (c == '"')
                {
                    continue;
                }

                if (c == ',')
                {
                    names.Add(sb.ToString());
                    sb.Clear();
                    continue;
                }

                sb.Append(c);
            }

            return names;
        }
    }
}
