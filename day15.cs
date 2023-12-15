using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day15
{
    internal class day15
    {
        static void Main(string[] args)
        {
            //the code only contains PART1:
            var inputFile = File.ReadAllLines("./input.txt");
            var input = new List<string>(inputFile);
            List<List<string>> result = input.Select(str => str.Split(',').ToList()).ToList();
            List<string> strings = result[0];
            int currentValue = 0;
            int Sum = 0;
            for (int i = 0; i < strings.Count; i++)
            {
                currentValue = 0;
                for(int j = 0; j < strings[i].Length; j++)
                {
                    currentValue = currentValue + strings[i][j];
                    currentValue = currentValue * 17;
                    currentValue = currentValue%256;
                }
                Sum += currentValue;
            }
            Console.WriteLine(Sum);
            Console.ReadKey();





            //TLevi
        }
    }
}
