using net_calculator_tester;

namespace CalculatorTester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Addition()
        {
            //Initialize
            Calculator calculator = new Calculator();

            //Act
            float result = calculator.Add(9, 3);

            //Assert
            Assert.AreEqual(12, result);
        }

        [Test]
        public void Test_Subtraction()
        {
            //Initialize
            Calculator calculator = new Calculator();

            //Act
            float result = calculator.Subtract(8, 4);

            //Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Test_Division()
        {
            //Initialize
            Calculator calculator = new Calculator();

            //Act
            float result = calculator.Divide(10, 5);

            //Assert
            Assert.Throws<ArgumentException>(() => { calculator.Divide(5, 0); });
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test_Multiplication()
        {
            //Initialize
            Calculator calculator = new Calculator();

            //Act
            float result = calculator.Multiply(3, 9);

            //Assert
            Assert.That(result, Is.EqualTo(27));
        }

        [Test]
        public void Test_Negative_numbers()
        {
            //Initialize
            Calculator calculator = new Calculator();

            //Act
            float result1 = calculator.Add(-7, 4);
            float result2 = calculator.Subtract(-10, -5);
            float result3 = calculator.Divide(8, -4);
            float result4 = calculator.Multiply(-6, 7);

            //Assert
            Assert.AreEqual(-3, result1);
            Assert.AreEqual(-5, result2);
            Assert.AreEqual(-2, result3);
            Assert.AreEqual(-42, result4);
        }
    }
}