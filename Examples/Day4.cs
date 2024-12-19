using Days;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using System.Collections.Generic;
using System.Reflection;

namespace Examples
{
    [TestClass]
    public class Day4
    {
        IDay day = new Days.Day4();

        [TestMethod]
        public void ExampleA()
        {
            string pathInput = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Inputs", $"Day4", $"ExampleA.txt");

            int answerA = day.AnswerA(pathInput);
            int expectedAnswerA = 18;

            Assert.AreEqual(expectedAnswerA, answerA);
        }

        [TestMethod]
        public void ExampleB()
        {
            string pathInput = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Inputs", $"Day4", $"ExampleB.txt");

            int answerB = day.AnswerB(pathInput);
            int expectedAnswerB = 48;

            Assert.AreEqual(expectedAnswerB, answerB);

        }
    }
}