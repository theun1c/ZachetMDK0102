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
        /// <param name="rank">Ставка сотрудника. должна быть выше 0</param>
        /// <returns></returns>
        public decimal SalaryCalculation(string post, decimal rank)
        {
            // проверка ставки
            if (rank <= 0)
            {
                return -1m;
            }

            // проверка должности
            if (String.IsNullOrEmpty(post))
            {
                return -1m;
            }

            // преобразование строки должности к единому виду
            string normalizedPost = post.ToLower().Trim();

            decimal baseSalary;

            // нахождение базовой ЗП исходя из должности
            if (normalizedPost == "директор")
            {
                baseSalary = 30000m;
            }
            else if (normalizedPost == "мастер")
            {
                baseSalary = 20000m;
            }
            else if (normalizedPost == "водитель")
            {
                baseSalary = 15000;
            }
            else 
            {
                return -1m; 
            }

            // калькуляция итоговой зп
            decimal salary = baseSalary * rank * 0.87m;

            // возврат зп
            return salary;
        }
    }
}
