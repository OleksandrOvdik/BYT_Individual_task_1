using Part_2;

namespace Part_2_Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void TestAddition()
        {
            Assert.That(new Calculator(5.5, 4.5, '+').Calculate(), Is.EqualTo(10.0));
        }

        [Test]
        public void TestSubtraction()
        {
            Assert.That(new Calculator(10, 7, '-').Calculate(), Is.EqualTo(3));
        }

        [Test]
        public void TestMultiplication()
        {
            Assert.That(new Calculator(8, 4, '*').Calculate(), Is.EqualTo(32));
        }

        [Test]
        public void TestValidDivision()
        {
            Assert.That(new Calculator(20, 5, '/').Calculate(), Is.EqualTo(4));
        }

        [Test]
        public void TestDivisionByZeroScenario()
        {
            Assert.Throws<DivideByZeroException>(() => new Calculator(10, 0, '/').Calculate());
        }

        [Test]
        public void TestInvalidOperationScenario()
        {
            Assert.Throws<InvalidOperationException>(() => new Calculator(10, 5, 'x').Calculate());
        }
    }
}