using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class day2
    {
        static void Main(string[] args)
        {
            var inputFile = File.ReadAllLines("C:\\!KELL\\prog\\day2/input.txt");
            var input = new List<string>(inputFile);
            string CurrentLine = "";
            int currentOsszeg = 0;
            Boolean Possible = true;
            int Out = 0;
            int Out2 = 0;
            int maxG = 0;
            int maxB = 0;
            int maxR = 0;

            for (int i = 0; i < input.Count; i++)
            {
                input[i] = input[i].Replace($"Game {i+1}: ", "");
                input[i] = input[i].Replace(";", ",");
                input[i] = input[i].Replace(", ", "");
                input[i] = input[i].Replace(" green", "g");
                input[i] = input[i].Replace(" red", "r");
                input[i] = input[i].Replace(" blue", "b");
                CurrentLine = input[i];
                Possible = true;
                for (int j = 0; j < CurrentLine.Length; j++)
                {
                    switch (CurrentLine[j])
                    {
                        case 'r':
                            if (currentOsszeg > 12)
                            {
                                Possible = false;
                            }
                            if (currentOsszeg > maxR)
                            {
                                maxR = currentOsszeg;
                            }
                            currentOsszeg = 0;
                            break;
                        case 'b':
                            if (currentOsszeg > 14)
                            {
                                Possible = false;
                            }
                            if (currentOsszeg > maxB)
                            {
                                maxB = currentOsszeg;
                            }
                            currentOsszeg = 0;
                            break;
                        case 'g':
                            if (currentOsszeg > 13)
                            {
                                Possible = false;
                            }
                            if (currentOsszeg > maxG)
                            {
                                maxG = currentOsszeg;
                            }
                            currentOsszeg = 0;
                            break;
                        default:
                            if (currentOsszeg == 0)
                            {
                                currentOsszeg = currentOsszeg + Convert.ToInt16(CurrentLine[j]) - 48;
                            }
                            else
                            {
                                currentOsszeg = (currentOsszeg * 10) + Convert.ToInt16(CurrentLine[j]) - 48;
                            }
                            break;
                    }
                }
                Out2 = Out2 + (maxG * maxB * maxR);
                maxB = 0; maxG = 0; maxR = 0;
                if (Possible == true)
                {
                    Out = Out + i + 1;
                }
                currentOsszeg = 0;
            }
            Console.WriteLine($"First Task: {Out}");
            Console.WriteLine($"Second Task: {Out2}");
            Console.ReadKey();
        }

    }
}











//TLevi