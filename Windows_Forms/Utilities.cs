using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms
{
    class Utilities<T> where T : IComparable<T>
    {
        public static vector<int> RandomInt(int size, int min, int max)
        {
            var mas = new vector<int>();
            var rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                mas.Push(rnd.Next(min, max));
                /*if (i == 5) mas.InsertAt(i * 3);
                else mas.InsertAt(i);*/
            }
            return mas;
        }

        public static vector<double> RandomDouble(int size, int min, int max)
        {
            var mas = new vector<double>();
            var rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                mas.Push(rnd.NextDouble() * rnd.Next(min, max));
            }
            return mas;
        }

        public static vector<string> RandomString(int size)
        {
            var mas = new vector<string>();
            var rnd = new Random();
            string tstr = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < rnd.Next(1, 5); j++)
                {
                    tstr += (char)rnd.Next(65, 91);
                }
                mas.Push(tstr);
                tstr = "";
            }
            return mas;
        }

        public static vector<T> Copy(vector<T> mas)
        {
            vector<T> mas1 = new vector<T>();
            for (int i = 0; i < mas.Length; i++)
                mas1.Push(mas[i].Element);
            return mas1;
        }

        public static vector<T> SortVar(vector<T> mas, sortAbstract<T> sort)
        {
            vector<T> massorted = new vector<T>();
            massorted = sort.Sorting(mas);
            return massorted;
        }
    }

}
