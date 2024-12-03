using Days;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using System.Collections.Generic;

namespace Examples
{
    [TestClass]
    public class Day1
    {
        IDay day = new Days.Day1();

        [TestMethod]
        public void ExampleA()
        {
            int answerA = day.AnswerA();
            int expectedAnswerA = 11;

            Assert.AreEqual(expectedAnswerA, answerA);
        }

        [TestMethod]
        public void ExampleB()
        {
            int answerA = day.AnswerB();
            int expectedAnswerB;

            Assert.AreEqual(expectedAnswerB, answerA);

        }
    }
}