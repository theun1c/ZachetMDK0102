namespace TestSession2.Tests
{
    public class TestSession2Tests
    {
        // позитивные тесты 10 шт.

        /// <summary>
        /// Функция для тестирования расчета зарплаты для директора с корректной ставкой 
        /// </summary>
        [Fact]
        public void SalaryCalculation_DirectorValiData_ReturnsCorrectValue()
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

        /// <summary>
        /// Функция для тестирования расчета зарплаты для директора (запись должности с больших букв)
        /// </summary>
        [Fact]
        public void SalaryCalculation_DirectorUpperCasePost_ReturnsCorrectValue()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 1;
            string post = "ДИРЕКТОР";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, 26100);
        }

        /// <summary>
        /// Функция для тестирования ввода английского значения должности директора
        /// </summary>
        [Fact]
        public void SalaryCalculation_DirectorEngPost_ReturnsMinulOne()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 1;
            string post = "director";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, -1);
        }

        /// <summary>
        /// Функция для тестирования ввода должности с пустыми местами и пробелами между букв
        /// </summary>
        [Fact]
        public void SalaryCalculation_PostWithSpaces_ReturnsMinusOne()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 1;
            string post = "   д ире кт ор   ";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, -1);
        }

        /// <summary>
        /// Функция для тестирования ввода названия должности директора с пустыми местами до и после должности
        /// </summary>
        [Fact]
        public void SalaryCalculation_DirectorPostWithSpacesAfterBeforeOnly_ReturnsCorrectValue()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 1;
            string post = "   директор   ";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, 26100);
        }

        /// <summary>
        /// Функция для тестирования ввода названия должности директора на английском языке с пустыми местами до и после слова
        /// </summary>
        [Fact]
        public void SalaryCalculation_DirectorEngPostWithSpacesAfterBeforeOnly_ReturnsMinusOne()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 1;
            string post = "   director   ";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, -1);
        }

        /// <summary>
        /// Функция для тестирования расчета зарплаты для должности мастера
        /// </summary>
        [Fact]
        public void SalaryCalculation_MasterValidData_ReturnsCorrectValue()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 1;
            string post = "мастер";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, 17400);
        }

        /// <summary>
        /// Функция для тестирования расчета зарплаты для должности мастера при вводе на английском языке
        /// </summary>
        [Fact]
        public void SalaryCalculation_MasterEngPost_ReturnsMinusOne()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 1;
            string post = "master";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, -1);
        }

        /// <summary>
        /// Функция для тестирования расчета зарплаты для водителя 
        /// </summary>
        [Fact]
        public void SalaryCalculation_DriverCorrectData_ReturnsCorrectValue()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 0.5;
            string post = "водитель";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, 6525);
        }

        /// <summary>
        /// Функция для тестирования зарплаты водителя с вводом названия должности с пустыми местами до и после + с разными буквами
        /// </summary>
        [Fact]
        public void SalaryCalculation_DriverPostWithSpaceAndUpperCaseLetters_ReturnsCorrectValue()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 0.5;
            string post = "ВодитЕЛь ";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, 6525);
        }

        // 6 негативных тестовых сценариев

        /// <summary>
        /// Функция для тестирования записи числа в качестве должности
        /// </summary>
        [Fact]
        public void SalaryCalculation_AddNumberForPost_ReturnsMinusOne()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 0.5;
            string post = "1233123123123";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, -1);
        }

        /// <summary>
        /// Функция для тестирования записи символа в качестве должности
        /// </summary>
        [Fact]
        public void SalaryCalculation_AddSymbolForPost_ReturnsMinusOne()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 0.5;
            string post = "+";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, -1);
        }

        /// <summary>
        /// Функция для тестирования нулевого значения должности
        /// </summary>
        [Fact]
        public void SalaryCalculation_AddNullForPost_ReturnsMinusOne()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 0.5;
            string post = null;

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, -1);
        }

        /// <summary>
        /// Функция для тестирования ввода пустого значения для должности
        /// </summary>
        [Fact]
        public void SalaryCalculation_AddWhiteSpaceForPost_ReturnsMinusOne()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 0.5;
            string post = "";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, -1);
        }

        /// <summary>
        /// Функция для тестирования нулевой ставки
        /// </summary>
        [Fact]
        public void SalaryCalculation_ZeroBet_ReturnsMinusOne()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = 0;
            string post = "директор";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, -1);
        }

        /// <summary>
        /// Функция для тестирования ввода минусовой ставки
        /// </summary>
        [Fact]
        public void SalaryCalculation_AddMinusBet_ReturnsMinusOne()
        {
            // Arrange
            var calculation = new Calculation();
            double bet = -1;
            string post = "директор";

            // Act
            double salary = calculation.SalaryCalculation(post, bet);

            // Assert
            Assert.Equal(salary, -1);
        }
    }
}
