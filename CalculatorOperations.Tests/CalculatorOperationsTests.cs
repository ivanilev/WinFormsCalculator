using NUnit.Framework;
using System;

namespace CalculatorOperations.Tests
{
    [TestFixture]
    public class CalculatorOperationsTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new CalculatorController();

            var result = sut.OnOperation("1,2+");
            Assert.That(result, Is.EqualTo(1.2));

            result = sut.OnOperation("1,5=");
            Assert.That(result, Is.EqualTo(2.7));
        }
        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new CalculatorController();

            var result = sut.OnOperation("1,2*");
            Assert.That(result, Is.EqualTo(1.2));

            result = sut.OnOperation("0,4=");
            Assert.That(result, Is.EqualTo(0.48));
        }
        [Test]
        public void ShouldDivideTwoNumbers()
        {
            var sut = new CalculatorController();

            var result = sut.OnOperation("0,2/");
            Assert.That(result, Is.EqualTo(0.2));

            result = sut.OnOperation(",4=");
            Assert.That(result, Is.EqualTo(0.5).Within(0.00001));
        }
        [Test]
        public void ShouldSubtractTwoNumbers()
        {
            var sut = new CalculatorController();

            var result = sut.OnOperation("1,0-");
            Assert.That(result, Is.EqualTo(1));

            result = sut.OnOperation("0,17=");
            Assert.That(result, Is.EqualTo(0.83));
        }
        [Test]
        public void ShouldEquateParamToItself()
        {
            var sut = new CalculatorController();

            var result = sut.OnOperation("1=");
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void ShouldSaveClearAndRecallMemory()
        {
            var sut = new MemoryClass();

            sut.SaveMemory(2.10);

            Assert.That(sut.Recallmemory(), Is.EqualTo(2.10).Within(0.01));

            sut.clearMemory();
            Assert.That(sut.Recallmemory(), Is.EqualTo(null));
        }
        [Test]
        public void ShouldUndoCorrectly()
        {
            var sut = new CalculatorController();

            double result;

            for (int i = 0; i < 5; i++)
            {
                result = sut.OnOperation("1+");
            }

            result = sut.OnOperation("1=");
            Assert.That(result, Is.EqualTo(6));

            sut.UndoOperation();

            result = sut.OnOperation("2,12=");
            Assert.That(result, Is.EqualTo(7.12).Within(0.01));

            for (int i = 0; i < 10; i++)
            {
                sut.UndoOperation();
            }

            Assert.That(() => sut.UndoOperation(), Throws.Nothing);
        }
        [Test]
        public void ShouldThrowDivideByZeroException()
        {
            var sut = new CalculatorController();

            var result = sut.OnOperation("2/");
            Assert.That(() => sut.OnOperation("0="), Throws.TypeOf<DivideByZeroException>());
        }
    }
}
