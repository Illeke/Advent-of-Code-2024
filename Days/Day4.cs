using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Days
{
    public class Day4 : IDay
    {
        string pattern = @"(?=((XMAS)|(SAMX)))";

        public int AnswerA(string pathInput)
        {
            char[,] parsedInput = parseInput(pathInput);
            
            int numXmas = 0;

            numXmas += numRows(parsedInput);
            numXmas += numColumns(parsedInput);
            numXmas += numDiagonals(parsedInput);

            return numXmas;
        }

        public int AnswerB(string pathInput)
        {
            char[,] parsedInput = parseInput(pathInput);

            return 0;
        }

        private int numRows(char[,] parsedInput)
        {
            int numXmasRows = 0;
            for (int i = 0; i < parsedInput.GetLength(0); i++)
            {
                string s = new string(Enumerable.Range(0, parsedInput.GetLength(1))
                    .Select(x => parsedInput[i, x]).ToArray());
                var matchesRow = Regex.Matches(s, pattern).Count();
                numXmasRows += matchesRow;
            }
            return numXmasRows;
        }

        private int numColumns(char[,] parsedInput)
        {
            int numXmasColumns = 0;
            for (int i = 0; i < parsedInput.GetLength(1); i++)
            {
                string s = new string(Enumerable.Range(0, parsedInput.GetLength(0))
                    .Select(x => parsedInput[x, i]).ToArray());
                numXmasColumns += Regex.Matches(s, pattern).Count();
            }
            return numXmasColumns;
        }

        private int numDiagonals(char[,] parsedInput)
        {
            int numXmasDiagonals = 0;


            return numXmasDiagonals;
        }

        private char[,] parseInput(string pathInput)
        {
            string[] inputText= File.ReadAllLines(pathInput);
            char[,] parsedInput = new char[inputText.Length, inputText[0].Length];

            for (int i = 0; i <inputText.Length; i++)
            {
                var charArrayInput = inputText[i].ToCharArray();
                for (int j = 0; j < inputText.Length; j++)
                {
                    parsedInput[i, j] = charArrayInput[j];
                }
            }

            return parsedInput;
        }
    
    }
}