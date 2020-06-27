using System;
using System.Collections.Generic;
using System.IO;
using handleData;

namespace AdventOfCode2019
{
    public class Day2
    {
        //--- Day 2: 1202 Program Alarm ---
        //https://adventofcode.com/2019/day/2
        //
        public void Task1()
        {
            List<int> data = Data.GetIntListFromCSV("../../day2.txt");

            data[1] = 12;
            data[2] = 2;


            for (int i = 0; i < data.Count; i += 4)
            {
                if (i + 3 > data.Count)
                {
                    break;
                }
                int halt = 0;

                switch (data[i])
                {
                    case 1:
                        halt = 0;
                        data[(data[i + 3])] = data[(data[i + 1])] + data[(data[i + 2])];
                        break;
                    case 2:
                        halt = 0;
                        data[data[i + 3]] = data[data[i + 1]] * data[data[i + 2]];
                        break;
                    case 99:
                        halt = 1;
                        //Console.WriteLine(i);
                        Console.WriteLine("Encountered opcode 99.");
                        break;
                    default:
                        halt = 2;
                        Console.WriteLine("Encountered unknown opcode.");
                        break;
                }

                if (halt != 0)
                {
                    break;
                }

            }

            Console.WriteLine($"Day 2 Task 1 Solution: {data[0]}");
        }
        public void Task2()
        {

        }
    }

}
namespace handleData
{
    partial class Data
    {
        internal static List<int> GetIntListFromCSV(String inp)
        {

            Console.WriteLine($"Reading from input file {inp}");

            string dataS = "";

            List<int> data = new List<int>();

            using (var reader = new StreamReader(inp))
            {
                while (!reader.EndOfStream)
                {
                    dataS += reader.ReadLine();
                }
            }


            //Console.WriteLine(dataS);
            string[] dataArrayStr = dataS.Split(',');
            foreach (var item in dataArrayStr)
            {
                //Console.WriteLine(item);
                data.Add(int.Parse(item));
            }

            return data;
        }
    }
}
