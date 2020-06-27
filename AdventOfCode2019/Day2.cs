using System;
using System.Collections.Generic;
using System.IO;
using handleData;
using System.Linq;

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

        //--- Day 2: 1202 Program Alarm ---
        //https://adventofcode.com/2019/day/2
        // Task 2
        public void Task2()
        {
            List<int> dataFresh = Data.GetIntListFromCSV("../../day2.txt");
            int[] data = dataFresh.ToArray(); ;
            
            foreach (int x1 in Enumerable.Range(0, 100))
            {
                foreach (int x2 in Enumerable.Range(0, 100))
                {
                    dataFresh.CopyTo(data);

                    //Console.WriteLine(data[0]);

                    data[1] = x1;
                    data[2] = x2;

                    //Console.WriteLine($"Trying {x1}, {x2}");

                    for (int i = 0; i < data.Count(); i += 4)
                    {
                        if (i + 3 > data.Count())
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
                                //Console.WriteLine("Encountered opcode 99.");
                                break;
                            default:
                                halt = 2;
                                //Console.WriteLine("Encountered unknown opcode.");
                                
                                break;
                        }

                        if (halt != 0)
                        {
                            break;
                        }

                    }
                    if(data[0]== 19690720)
                    {
                            Console.Write(x1);
                            Console.WriteLine(x2);
                        return;
                    }
                }
            }



            Console.WriteLine("Solution not found.");

            
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
