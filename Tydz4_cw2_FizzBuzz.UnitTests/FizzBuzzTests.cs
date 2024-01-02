using NUnit.Framework;

namespace Tydz4_cw2_FizzBuzz.UnitTests
{
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_WhenInputIsDivisibleOnlyBy3_ShouldReturnFizz()
        {
            //Arrange
            //var fizzBuzz = new FizzBuzz();
            var inputTestValue = 3;
            var expectedResult = "Fizz";

            //Act
            var result = FizzBuzz.GetOutput(inputTestValue);

            //Assert
            //Assert.That(result, Is.EqualTo(expectedResult));
            Assert.Equals(expectedResult, result);
        }

        [Test]
        public void GetOutput_WhenInputIsDivisibleOnlyBy5_ShouldReturnBuzz()
        {
            //Arrange
            //var fizzBuzz = new FizzBuzz();
            var inputTestValue = 5;
            var expectedResult = "Buzz";

            //Act
            var result = FizzBuzz.GetOutput(inputTestValue);

            //Assert
            //Assert.That(result, Is.EqualTo(expectedResult));
            Assert.Equals(expectedResult, result);
        }

        [Test]
        public void GetOutput_WhenInputIsDivisibleBy3And5_ShouldReturnFizzBuzz()
        {
            //Arrange
            //var fizzBuzz = new FizzBuzz();
            var inputTestValue = 15;
            var expectedResult = "FizzBuzz";

            //Act
            var result = FizzBuzz.GetOutput(inputTestValue);

            //Assert
            //Assert.That(result, Is.EqualTo(expectedResult));
            Assert.Equals(expectedResult, result);
        }

        [Test]
        public void GetOutput_WhenInputIsNotDivisibleBy3And5_ShouldReturnInputValue()
        {
            //Arrange
            //var fizzBuzz = new FizzBuzz();
            var inputTestValue = 7;
            var expectedResult = 7;

            //Act
            var result = FizzBuzz.GetOutput(inputTestValue);

            //Assert
            //Assert.That(result, Is.EqualTo(expectedResult));
            Assert.Equals(expectedResult, result);
        }

    }
}
