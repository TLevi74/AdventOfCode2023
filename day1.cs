using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Collections;

namespace day1
{
    internal class day1
    {
        
        static void Main(string[] args)
        {
            //---------------------partone--------------------------
            var inputFile = File.ReadAllLines("C:\\!KELL\\prog\\day1/input.txt");
            var input = new List<string>(inputFile);
            int Answer = Solutions(input);
            Console.WriteLine($"First output: {Answer}");

            //---------------------parttwo--------------------------

            var wordToNumber = new Dictionary<string, string>
            {
            {"one", "o1e"},
            {"two", "t2o"},
            {"three", "t3e"},
            {"four", "f4"},
            {"five", "f5e"},
            {"six", "s6"},
            {"seven", "s7n"},
            {"eight", "e8t"},
            {"nine", "n9e"}
            };
            string replaceWith = "";
            for (int i = 0; i < input.Count; i++)
            {
                replaceWith = ReplaceWordsWithNumbers(input[i], wordToNumber);
                input[i] = replaceWith;
            }
            Answer = Solutions(input);
            Console.WriteLine($"Second output: {Answer}");
            Console.ReadKey();
        }


        //----------functions-----------




        static string ReplaceWordsWithNumbers(string whatTo, Dictionary<string, string> wordToNumber)
        {

            foreach (var entry in wordToNumber)
            {
                whatTo = whatTo.Replace(entry.Key, entry.Value);
            }
            
            return whatTo;
        }





        static int Solutions(List<string> input)
        {
            int FirstNum = 0;
            int LastNum = 0;
            int Out = 0;

            for (int i = 0; i < input.Count; i++)
            {
                FirstNum = 0;

                string Current = "0";
                for (int j = 0; j < input[i].Length; j++)
                {

                    Current = Convert.ToString(input[i][j]);
                    if (Current == "1" || Current == "2" || Current == "3" || Current == "4" || Current == "5" || Current == "6" || Current == "7" || Current == "8" || Current == "9")
                    {
                        FirstNum = Convert.ToInt32(Current);
                        break;
                    }
                }

                LastNum = 0;
                for (int j = 0; j < input[i].Length; j++)
                {

                    Current = Convert.ToString(input[i][j]);
                    if (Current == "1" || Current == "2" || Current == "3" || Current == "4" || Current == "5" || Current == "6" || Current == "7" || Current == "8" || Current == "9")
                    {
                        LastNum = Convert.ToInt32(Current);
                    }
                }
                Out = Out + 10 * FirstNum + LastNum;
            }

            return Out;
        }
            
    }
}














//Made By TLevi74