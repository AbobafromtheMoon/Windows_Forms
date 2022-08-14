using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms
{
    abstract class sortAbstract<T> where T : IComparable<T>
    {
        public abstract vector<T> Sorting(vector<T> unsorted);
    }
    class BinarySort<T> : sortAbstract<T> where T : IComparable<T>
    {
        public int comparison = 0, shift = 0;
        public override vector<T> Sorting(vector<T> mas)
        {
            int i, loc, j;
            Node<T> selected;
            for (i = 1; i < mas.Length; ++i)
            {
                j = i - 1;
                selected = mas[i];
                loc = BinarySearch(mas, selected, 0, j);
                if (mas[i] < mas[i - 1])
                {
                    if (loc != i)
                    {
                        shift++;
                    }
                    mas.RemoveAt(i);
                    mas.InsertA(loc, selected);
                }
            }
            return mas;
        }
        int BinarySearch(vector<T> mas, Node<T> item, int low, int high)
        {
            if (high <= low) return (item > mas[low]) ? (low + 1) : low;
            int half = (low + high) / 2;
            comparison++;
            if (item == mas[half]) return half;
            if (item > mas[half]) return BinarySearch(mas, item, half + 1, high);
            return BinarySearch(mas, item, low, half - 1);
        }
    }
    class QuickSort<T> : sortAbstract<T> where T : IComparable<T>
    {
        public int comparison1 = 0, shift1 = 0;
        vector<T> mas1 = new vector<T>();
        public override vector<T> Sorting(vector<T> mas)
        {
            mas1 = mas;
            Quick(0, mas.Length - 1);
            return mas1;

        }
        private void Quick(int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var pivot = Sort(left, right);
            Quick(left, pivot - 1);
            Quick(pivot + 1, right);
        }

        private int Sort(int left, int right)
        {
            var point = left;

            for (int i = left; i <= right; i++)
            {
                if (mas1[i] < mas1[right])
                {
                    comparison1++;
                    mas1.swap(point, i);
                    if (point != i)
                    {
                        shift1++;
                    }
                    point++;
                }
            }
            mas1.swap(point, right);
            if (point != right)
            {
                shift1++;
            }
            return point;
        }
    }
}

