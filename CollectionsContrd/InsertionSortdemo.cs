using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsContrd
{
    internal class InsertionSortdemo
    {
        public static void insert(int[] a, int n)
        {
            int i, j, temp;
            for ( i = 1; i < n; i++)
            {
                temp = a[i];
                j = i -1;
                while (j>=0 && temp <= a[j])
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = temp;
            }
        }

        public static  void print(int[] a,int n)
        {
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] a =new int[6] { 11, 2, 34, 52, 14, 45 };
            insert(a, a.Length);
            print(a,a.Length);
            Console.Read();


        }
    }
}
