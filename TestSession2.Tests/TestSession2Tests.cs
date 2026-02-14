namespace TestSession2.Tests
{
    public class TestSession2Tests
    {
        [Fact]
        public void SalaryCalculation_ValiData_ReturnsCorrectValue()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 1;
            string post = "директор";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, 26100);
        }
    }
}
