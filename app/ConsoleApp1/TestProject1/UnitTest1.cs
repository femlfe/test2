
using ConsoleApp1.Classes;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            Calcuation calc = new Calcuation();

            // Act
            var result = calc.Sum(2, 3);

            // Assert
            Assert.Equal(5, result);
        }
    }
}