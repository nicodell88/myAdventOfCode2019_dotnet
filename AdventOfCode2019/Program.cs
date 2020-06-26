using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace AdventOfCode2019
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);

            List<int> Data = new List<int>();

            using (var reader = new StreamReader("../../day1.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int line = int.Parse(reader.ReadLine());
                    Data.Add(line);
                }
            }

            //foreach (int element in Data)
            //{
            //    Console.WriteLine($"{element}");
            //}
            //Console.WriteLine("@@@@@@@@@@@@@@@@@");

            int[] DataArray = Data.ToArray();

            //foreach (var element in DataArray)
            //{
            //    Console.WriteLine($"{element}");
            //}
            //Console.WriteLine("@@@@@@@@@@@@@@@@@");

            Console.WriteLine(DataArray.Sum());

            //foreach (var element in DataArray)
            for (int i = 0; i < DataArray.Length; i++)
            {
                DataArray[i] = DataArray[i]/3 - 2;
            }

            Console.WriteLine(DataArray.Sum());
            //Console.WriteLine(DataArray.Length);

        }
    }
}
