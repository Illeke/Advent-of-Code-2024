using System;
using System.Collections.Immutable;
using System.Reflection.Metadata;

namespace Days
{
    public class Day1 : IDay
    {
        public int AnswerA(string pathInput)
        {
            IEnumerable<string> inputLines= File.ReadLines(pathInput);
            List<int> listOne = new List<int>();
            List<int> listTwo = new List<int>();

            foreach (string line in inputLines)
            {
                // TODO
            }

            listOne.Sort();
            listTwo.Sort();
            int sum = listOne.Zip(listTwo, (x, y) => Math.Abs(x - y)).Sum();
            
            return sum;
        }

        public int AnswerB(string pathInput)
        {
            throw new NotImplementedException();
        }
    }
}