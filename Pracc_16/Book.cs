using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Book
    {
        private string[] chapters = new string[10];

        public string this[int index]
        {
            get
            {
                return chapters[index];
            }
            set
            {
                chapters[index] = value;
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < chapters.Length; i++)
            {
                if (chapters[i] != null)
                    result += $"{i + 1}. {chapters[i]}\n";
            }
            return result;
        }
    }
}
