using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43l0v3k
{
    internal class ObjectCounter
    {
        private static int count = 0;

        public ObjectCounter()
        {
            count++;
        }

        public static void ShowCount()
        {
            Console.WriteLine($"Количество созданных объектов: {count}");
        }
    }

}
