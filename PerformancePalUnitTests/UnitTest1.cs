using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PerformancePal;
using System.Collections.Generic;

namespace PerformancePalUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testMean()
        {
            List<int> testDataSet = new List<int>();
            testDataSet.Add(1);
            testDataSet.Add(2);
            testDataSet.Add(3);
            testDataSet.Add(4);
            testDataSet.Add(5);
            testDataSet.Add(6);
            testDataSet.Add(7);
            testDataSet.Add(8);
            testDataSet.Add(9);
            testDataSet.Add(10);
            Assert.AreEqual(FormSelectGraph.getMean(testDataSet), 5.5);
        }

        [TestMethod]
        public void testStandardDeviation()
        {
            List<int> testDataSet = new List<int>();
            testDataSet.Add(1);
            testDataSet.Add(2);
            testDataSet.Add(3);
            testDataSet.Add(4);
            testDataSet.Add(5);
            testDataSet.Add(6);
            testDataSet.Add(7);
            testDataSet.Add(8);
            testDataSet.Add(9);
            testDataSet.Add(10);
            Assert.AreEqual(FormSelectGraph.getStandardDeviation(testDataSet), 2.8723);
        }

        [TestMethod]
        public void testZscore()
        {
            List<int> testDataSet = new List<int>();
            testDataSet.Add(1);
            testDataSet.Add(2);
            testDataSet.Add(3);
            testDataSet.Add(4);
            testDataSet.Add(5);
            testDataSet.Add(6);
            testDataSet.Add(7);
            testDataSet.Add(8);
            testDataSet.Add(9);
            testDataSet.Add(10);
            Assert.AreEqual(FormSelectGraph.getZScore(3, FormSelectGraph.getMean(testDataSet), FormSelectGraph.getStandardDeviation(testDataSet)), -0.8704);
        }
    }
}
