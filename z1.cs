﻿using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace DZ2
{
    public class z1
    {
        public static void AddStroki(ref int[][] mass, string[] strings)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                string[] str = strings[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                mass[i] = new int[str.Length];
                for (int j = 0; j < str.Length; j++)
                {
                    if (int.TryParse(str[j], out int value))
                    {
                        mass[i][j] = value;
                    }
                    else
                    {
                        mass[i][j] = 0;
                    }
                    Console.Write(mass[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void MaxElemStrOFMAss(in int[][] mass, out int[] result)
        {
            result = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                int max = -int.MaxValue;
                for (int j = 0; j < mass[i].Length; j++)
                {
                    if (mass[i][j] > max)
                    {
                        max = mass[i][j];
                    }
                }
                result[i] = max;
            }
        }

        public static void MinElemStrOFMAss(in int[][] mass, out int[] result)
        {
            result = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < mass[i].Length; j++)
                {
                    if (mass[i][j] < min)
                    {
                        min = mass[i][j];
                    }
                }
                result[i] = min;
            }
        }

        public static void SumElemStrOFMAss(in int[][] mass, out int[] result)
        {
            result = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < mass[i].Length; j++)
                {
                    sum += mass[i][j];
                }
                result[i] = sum;
            }
        }
        static void Main()
        {
            Console.WriteLine("Введите количество строк:");
            int N = int.Parse(Console.ReadLine());
            int[][] mass = new int[N][];

            string[] command = new string[N];
            Console.WriteLine("Заполните строки:");
            for (int i = 0; i < N; i++)
            {
                command[i] = Console.ReadLine();
            }

            AddStroki(ref mass, command);

            MaxElemStrOFMAss(in mass, out int[] resultmax);
            for (int i = 0; i < resultmax.Length; i++)
            {
                Console.WriteLine("В {0} строке максимальное значение:{1}", i + 1, resultmax[i]);
            }

            MinElemStrOFMAss(in mass, out int[] resultmin);
            for (int i = 0; i < resultmin.Length; i++)
            {
                Console.WriteLine("В {0} строке минимальное значение:{1}", i + 1, resultmin[i]);
            }

            SumElemStrOFMAss(in mass, out int[] resultsum);
            for (int i = 0; i < resultmin.Length; i++)
            {
                Console.WriteLine("В {0} строке сумма значений:{1}", i + 1, resultsum[i]);
            }
        }
    }
}