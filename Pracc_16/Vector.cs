using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Vector
    {
        private double[] data;

        public Vector(params double[] values)
        {
            data = values;
        }

        public double this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public static double operator *(Vector a, Vector b)
        {
            double sum = 0;
            for (int i = 0; i < a.data.Length; i++)
            {
                sum += a.data[i] * b.data[i];
            }
            return sum;
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", data) + "]";
        }
    }
}
