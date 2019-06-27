using System;
using System.Collections.Generic;

namespace FreeCompiler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int max = 0; int sum = 0;
            Console.WriteLine("Enter integer number:");
           var num = int.Parse(Console.ReadLine());
            int[]p = { 1, 2, 4, 8, 16, 32, 64, 128 };
            List<int> arr1=new List<int>();
            for (int i = 0; i < p.Length; i++)
            {
                arr1.Add(p[i]);
            }
            ;
            List<int> results = new List<int>();
            for (int i = 0; i < arr1.Capacity; i++)
            {
                int fst = arr1[0];
                if (fst>arr1[i])
                {
                   max=fst;
                }
                if (max<num)
                {
                    results.Add(max);
                    var res = num - max;
                    int tmp1 = arr1[i];
                    if (res>arr1[i] && tmp1<arr1[i])
                    {
                        int ad = arr1[i]; 
                        results.Add(ad);
                        int nextres = res - ad;
                        do
                        {

                            if (nextres > arr1[i] && tmp1 < arr1[i])
                            {
                                int ad1 = arr1[i];
                                results.Add(ad1);
                            }
                        } while (nextres - ad != 0);
                        for (int x = 0; x < results.Capacity; x++)
                        {
                            sum = sum + results[x];
                            if (sum==num)
                            {
                                for (int y = 0; y < p.Length; y++)
                                {
                                    int[] bin = new int[50]; string binary=" ";
                                    if ( (results[x] == arr1[i]))
                                    {

                                        for (int z = 0; z < bin.Length; z++)
                                        {
                                            bin[z] = 1;
                                            if (results[x] == arr1[i] == false) bin[z] = 0;
                                            binary = bin[z].ToString();
                                        }
                                        Console.WriteLine("Binary is:");
                                        Console.WriteLine(binary);

                                    }

                                }

                            }
                        }

                    }

                }
            }
        }
    }
}
