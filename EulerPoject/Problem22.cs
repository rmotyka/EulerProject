using System.Text;

namespace EulerPoject
{
    public class Problem22
    {
        public void Calculate()
        {
            var names = ReadNamesFile();
            names.Sort();

            long result = 0;

            for (int i = 0; i < names.Count; i++)
            {
                var nameWort = GetNameWorth(names[i]);
                result += ((i + 1) * nameWort);
            }

            Console.WriteLine(result);
        }

        private int GetNameWorth(string nameText)
        {
            return Encoding.ASCII.GetBytes(nameText).Sum(x => x - 64);
        }

        private List<string> ReadNamesFile()
        {
            var names = new List<string>(60_000);

            using StreamReader sr = new("Resources\\Problem22\\0022_names.txt");
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

            names.Add(sb.ToString());

            return names;
        }
    }
}
