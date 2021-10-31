using System;
using AverageIndexSumsOfArrayClassLibrary;
using static System.Console;

namespace AverageIndexSumsOfArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var example1 = new int[] {1, 2, 3, 4, 5,};
            var example2 = new int[] {1, 0, 2, 20, 3};

            var averageIndex = new AverageIndexSumsOfArray();

            ShowConsoleResults(averageIndex, example1, example2);
            ReadKey();
        }

        private static void FormatedWriteLine(int[] array, int average)
        {
            WriteLine($"Array: {{ {string.Join(", ", array)} }} | Average: {average.ToString()}");
        }

        private static void ShowConsoleResults(AverageIndexSumsOfArray averageIndex, params int[][] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                FormatedWriteLine(arrays[i], averageIndex.GetIndex(arrays[i]));
            }
        }
    }
}