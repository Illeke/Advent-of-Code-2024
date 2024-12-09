using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Days
{
    public class Day1 : IDay
    {
        private const string pattern = @"\D+";
        private List<int> listOne;
        private List<int> listTwo;

        public int AnswerA(string pathInput)
        {
            parseInput(pathInput);

            listOne.Sort();
            listTwo.Sort();
            
            int sum = listOne.Zip(listTwo, (x, y) => Math.Abs(x - y)).Sum();
            
            return sum;
        }

        public int AnswerB(string pathInput)
        {
            parseInput(pathInput);

            Dictionary<int, int> occurencesListTwo = new Dictionary<int, int>();

            foreach (int number in listTwo)
            {
                if (occurencesListTwo.ContainsKey(number))
                {
                    occurencesListTwo[number]++;
                }
                else
                {
                    occurencesListTwo.Add(number, 1);
                }
            }

            int similarityScore = 0;

            foreach (int number in listOne)
            {
                if (occurencesListTwo.ContainsKey(number))
                {
                    similarityScore += number * occurencesListTwo[number];
                }
            }

            return similarityScore;
        }

        private void parseInput(string pathInput)
        {
            IEnumerable<string> inputLines = File.ReadLines(pathInput);
            
            listOne = new List<int>();
            listTwo = new List<int>();

            foreach (string line in inputLines)
            {
                var output = Regex.Split(line, pattern);
                listOne.Add(Int32.Parse(output[0]));
                listTwo.Add(Int32.Parse(output[1]));
            }


        }
    }
}