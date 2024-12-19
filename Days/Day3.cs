using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Days
{
    public class Day3 : IDay
    {
        

        public int AnswerA(string pathInput)
        {
            string pattern = @"(mul)\(\d+\,\d+\)";
            var input = parseInput(pathInput, pattern);
            
            return multiply(input);
        }

        public int AnswerB(string pathInput)
        {
            string pattern = @"(mul)\(\d+\,\d+\)|(don't\(\))|(do\(\))";
            var input = parseInput(pathInput, pattern);

            bool skip = false;
            var cleanedInput = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Equals("don't()"))
                {
                    skip = true;
                    continue;
                } else if (input[i].Equals("do()"))
                {
                    skip = false;
                    continue;
                } else if (skip)
                {
                    continue;
                }
                cleanedInput.Add(input[i]);
            }

            return multiply(cleanedInput);
        }

        private List<string> parseInput(string pathInput, string pattern)
        {
            string inputText= File.ReadAllText(pathInput);
            var parsedInput  = new List<string>();

            foreach (Match match in Regex.Matches(inputText, pattern))
            {
                parsedInput.Add(match.Value);
            }
                

            return parsedInput;
        }

        private int multiply(List<string> input)
        {
            var sumOfProducts = 0;

            foreach (var mul in input)
            {
                var intsInMul = Regex.Matches(mul, @"\d+");
                sumOfProducts = sumOfProducts + (Int32.Parse(intsInMul[0].Value) * Int32.Parse(intsInMul[1].Value));
            }

            return sumOfProducts;
        }
    
    }
}