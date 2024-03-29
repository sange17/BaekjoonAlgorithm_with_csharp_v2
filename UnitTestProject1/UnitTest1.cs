using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static WpfApp1.MainWindow;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestClass]
        public class CalculatorTest
        {
            [TestMethod]
            public void AddTest()
            {
                int number1 = 10;
                int number2 = 4;
                int expected = 14;
                Calculator calculator = new Calculator();
                int result = calculator.Add(number1, number2);
                Assert.AreEqual(expected, result);
            }
            [TestMethod]
            public void SubTest()
            {
                int number1 = 10;
                int number2 = 4;
                int expected = 10;
                Calculator calculator = new Calculator();
                int result = calculator.Sub(number1, number2);
                Assert.AreEqual(expected, result); //<-- fail
            }
        }

        [TestMethod]
        public void CallLoginProcessTest()
        {
            string id = "admin";
            string pwd = "123";
            Login login = new Login();
            bool result = login.CallLoginProcess(id, pwd);
            Assert.IsTrue(result);
        }
    }
}
