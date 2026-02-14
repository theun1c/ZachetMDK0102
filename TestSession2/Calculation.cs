using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSession2
{
    /// <summary>
    /// Класс для калькуляции заработной платы сотрудника
    /// </summary>
    public class Calculation
    {
        /// <summary>
        /// Главный метод для расчета заработной платы содержит базовые проверки и поиск ЗП сотрудника
        /// </summary>
        /// <param name="post">Должность сотрудника</param>
        /// <param name="bet">Ставка сотрудника. должна быть выше 0</param>
        /// <returns></returns>
        public double SalaryCalculation(string post, double bet)
        {
            // проверка ставки
            if (bet <= 0)
            {
                return -1;
            }

            // проверка должности
            if (String.IsNullOrEmpty(post))
            {
                return -1;
            }

            // преобразование строки должности к единому виду
            string normalizedPost = post.ToLower().Trim();

            double baseSalary;

            // нахождение базовой ЗП исходя из должности
            if (normalizedPost == "директор")
            {
                baseSalary = 30000;
            }
            else if (normalizedPost == "мастер")
            {
                baseSalary = 20000;
            }
            else if (normalizedPost == "водитель")
            {
                baseSalary = 15000;
            }
            else 
            {
                return -1; 
            }

            // калькуляция итоговой зп
            double salary = baseSalary * bet * 0.87;

            // возврат зп
            return salary;
        }
    }
}
