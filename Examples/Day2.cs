using Days;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using System.Collections.Generic;
using System.Reflection;

namespace Examples
{
    [TestClass]
    public class Day2
    {
        IDay day = new Days.Day2();

        [TestMethod]
        public void ExampleA()
        {
            string pathInput = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Inputs", $"Day2", $"ExampleA.txt");

            int answerA = day.AnswerA(pathInput);
            int expectedAnswerA = 2;

            Assert.AreEqual(expectedAnswerA, answerA);
        }

        [TestMethod]
        public void ExampleB()
        {
            string pathInput = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Inputs", $"Day2", $"ExampleA.txt");

            int answerB = day.AnswerB(pathInput);
            int expectedAnswerB = 4;

            Assert.AreEqual(expectedAnswerB, answerB);

        }
    }
}