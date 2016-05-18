using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day_20
{
    class BubbleSort
    {
        public int[] _a;
        public int _n;
        public int _swaps;
        public bool _sorted;

        public BubbleSort(int[] a, int n)
        {
            this._a = a;
            this._n = n;
            this._swaps = 0;
            this._sorted = false;
        }

        public void printBubbleSort()
        {
            Console.WriteLine("Array is sorted in {0} swaps.", _swaps);
            Console.WriteLine("First Element: {0}", _a[0]);
            Console.WriteLine("Last Element: {0}", _a[_a.Length - 1]);
        }

        public int bubbleSort()
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n - 1; j++)
                {
                    if (_a[j] > _a[j + 1])
                    {
                        //swap(a[j], a[j + 1]);
                        int tmp = _a[j];
                        _a[j] = _a[j + 1];
                        _a[j + 1] = tmp;

                        _swaps++;
                    }
                }

                if (_swaps == 0)
                    return _swaps;
            }
            return _swaps;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            BubbleSort b = new BubbleSort(a, n);
            b.bubbleSort();
            b.printBubbleSort();

            Console.ReadKey();
        }
    }
}
