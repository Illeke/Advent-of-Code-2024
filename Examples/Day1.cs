using Days;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using System.Collections.Generic;
using System.Reflection;

namespace Examples
{
    [TestClass]
    public class Day1
    {
        IDay day = new Days.Day1();

        [TestMethod]
        public void ExampleA()
        {
            string pathInput = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Inputs", $"Day1", $"ExampleA.txt");

            int answerA = day.AnswerA(pathInput);
            int expectedAnswerA = 11;

            Assert.AreEqual(expectedAnswerA, answerA);
        }

        [TestMethod]
        public void ExampleB()
        {
            string pathInput = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Inputs", $"Day1", $"ExampleA.txt");

            int answerB = day.AnswerB(pathInput);
            int expectedAnswerB = 31;

            Assert.AreEqual(expectedAnswerB, answerB);

        }
    }
}