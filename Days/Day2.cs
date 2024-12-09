using System;
using System.Collections;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Days
{
    public class Day2 : IDay
    {
        private const string pattern = @"\D+";
        private List<int[]> listOne;

        public int AnswerA(string pathInput)
        {
            parseInput(pathInput);

            int safeReports = 0;
            foreach (var report in listOne)
            {
                if (noDuplicates(report) && isSorted(report))
                {
                    bool safe = true;
                    for (int i = 0; i < report.Length - 1; i++)
                    {
                        if (Math.Abs(report[i] - report[i + 1]) > 3)
                        {
                            safe = false;
                            break;
                        }
                    }
                    if (safe) { safeReports++; }
                }
                else
                {
                    continue;
                }

            }
            
            return safeReports;
        }

        public int AnswerB(string pathInput)
        {
            parseInput(pathInput);

            int safeReports = 0;

            return safeReports;
        }

        private bool isSorted(int[] report)
        {
            int[] sortedAsc = report.OrderBy(x => x).ToArray();
            int[] sortedDesc = report.OrderByDescending(x => x).ToArray();

            return (Enumerable.SequenceEqual(sortedAsc, report) || Enumerable.SequenceEqual(sortedDesc, report));
        }

        private bool noDuplicates(int[] report)
        {
            return report.Distinct().Count() == report.Length;
        }

        private void parseInput(string pathInput)
        {
            IEnumerable<string> inputLines = File.ReadLines(pathInput);
            
            listOne = new List<int[]>();

            foreach (string line in inputLines)
            {
                string[] output = Regex.Split(line, pattern);
                listOne.Add(output.Select(int.Parse).ToArray());
            }
        }
    }
}