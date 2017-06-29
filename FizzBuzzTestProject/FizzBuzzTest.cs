using System;
using FizzBuzzChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTestProject
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void MultiplesOfThreePrintFizz()
        {
            //Arrange
            int input = 6;

            //Act
            using (ConsoleRedirector cr = new ConsoleRedirector())
            {
                IFizzBuzzCommandProcessor fizzBuzzPrintCommandProccessor = new FizzBuzzCommandProcessor();
                fizzBuzzPrintCommandProccessor.Process(input);
                //Assert

                Assert.IsTrue(cr.ToString().Contains("Fizz"));
            }
        }

        [TestMethod]
        public void MultiplesOfFivePrintBuzz()
        {
            //Arrange
            int input = 25;

            //Act
            using (ConsoleRedirector cr = new ConsoleRedirector())
            {
                IFizzBuzzCommandProcessor fizzBuzzPrintCommandProccessor = new FizzBuzzCommandProcessor();
                fizzBuzzPrintCommandProccessor.Process(input);
                //Assert

                Assert.IsTrue(cr.ToString().Contains("Buzz"));
            }
        }

        [TestMethod]
        public void MultiplesOfThreeAndFivePrintFizz()
        {
            //Arrange
            int input = 15;

            //Act
            using (ConsoleRedirector cr = new ConsoleRedirector())
            {
                IFizzBuzzCommandProcessor fizzBuzzPrintCommandProccessor = new FizzBuzzCommandProcessor();
                fizzBuzzPrintCommandProccessor.Process(input);
                //Assert

                Assert.IsTrue(cr.ToString().Contains("Fizz"));
            }
        }

        [TestMethod]
        public void MultiplesOfThreeAndFivePrintBuzz()
        {
            //Arrange
            int input = 15;

            //Act
            using (ConsoleRedirector cr = new ConsoleRedirector())
            {
                IFizzBuzzCommandProcessor fizzBuzzPrintCommandProccessor = new FizzBuzzCommandProcessor();
                fizzBuzzPrintCommandProccessor.Process(input);
                //Assert

                Assert.IsTrue(cr.ToString().Contains("Buzz"));
            }
        }

        [TestMethod]
        public void NitherMultiplesOfThreeNorFivePrintNothing()
        {
            //Arrange
            int input = 14;

            //Act
            using (ConsoleRedirector cr = new ConsoleRedirector())
            {
                IFizzBuzzCommandProcessor fizzBuzzPrintCommandProccessor = new FizzBuzzCommandProcessor();
                fizzBuzzPrintCommandProccessor.Process(input);
                //Assert

                Assert.IsTrue(cr.ToString().Contains(""));
            }
        }

    }
}
