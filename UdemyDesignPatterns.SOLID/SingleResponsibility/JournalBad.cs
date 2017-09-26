using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID
{
    public class JournalBad
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count} : {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        // too much responsibility
        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }

        // too much responsibility
        public static JournalBad Load(string filename)
        {
            return new JournalBad();
        }
    }
}
