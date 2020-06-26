using System;
using System.Collections.Generic;
using System.IO;

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

            foreach (int element in Data)
            {
                Console.WriteLine($"{element}");
            }

        }
    }
}
