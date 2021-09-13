using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPractices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Additional(100, 20) == 120);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Subtraction(100, 20) == 80);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Miltiplication(100, 20) == 2000);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Division(100, 20) == 5);
        }

        [Test]
        public void DivisionMustThrowException()
        {
            var calculatorTest = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculatorTest.Division(100, 0));
        }
    }
}
