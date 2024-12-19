using Days;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using System.Collections.Generic;
using System.Reflection;

namespace Examples
{
    [TestClass]
    public class Day3
    {
        IDay day = new Days.Day3();

        [TestMethod]
        public void ExampleA()
        {
            string pathInput = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Inputs", $"Day3", $"ExampleA.txt");

            int answerA = day.AnswerA(pathInput);
            int expectedAnswerA = 161;

            Assert.AreEqual(expectedAnswerA, answerA);
        }

        [TestMethod]
        public void ExampleB()
        {
            string pathInput = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Inputs", $"Day3", $"ExampleB.txt");

            int answerB = day.AnswerB(pathInput);
            int expectedAnswerB = 48;

            Assert.AreEqual(expectedAnswerB, answerB);

        }
    }
}