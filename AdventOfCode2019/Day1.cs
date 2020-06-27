
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; //inherit the sum method?


namespace AdventOfCode2019
{
    public class Day1
    {
        //Fuel required to launch a given module is based on its mass.
        //Specifically, to find the fuel required for a module,
        //take its mass, divide by three, round down, and subtract 2.
        public void Task1()
        {
            List<int> data = Data.GetIntList("../../day1.txt");

            for (int i = 0; i < data.Count; i++)
            {
                data[i] = data[i] / 3 - 2;
            }
            Console.WriteLine($"Solution to Task 1: {data.Sum()}");

        }

        //Fuel itself requires fuel just like a module - take its mass,
        //divide by three, round down, and subtract 2. However, that fuel also
        //requires fuel, and that fuel requires fuel, and so on.Any mass that
        //would require negative fuel should instead be treated as if it requires
        //zero fuel; the remaining mass, if any, is instead handled by wishing really hard,
        //which has no mass and is outside the scope of this calculation.
        public void Task2()
        {
            List<int> data = Data.GetIntList("../../day1.txt");
            List<int> fuel = new List<int>();
            foreach (var element in data)
            {
                int tmp = element;
                while (tmp / 3 - 2 > 0)
                {
                    tmp = tmp / 3 - 2;
                    fuel.Add(tmp);
                }
            }

            Console.WriteLine($"Solution to Task 2: {fuel.Sum()}");
        }
    }

    class Data
    {
        internal static List<int> GetIntList(String inp)
        {

            Console.WriteLine($"Reading from input file {inp}");

            List<int> data = new List<int>();

            using (var reader = new StreamReader(inp))
            {
                while (!reader.EndOfStream)
                {
                    int line = int.Parse(reader.ReadLine());
                    data.Add(line);
                }
            }

            return data;
        }
    }
}
