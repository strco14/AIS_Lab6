using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    /// <summary>
    ///Стратегия расчета зарплаты (паттерн Стратегия)
    /// </summary>
    public interface ISalaryCalculationStrategy
    {
        /// <summary>
        /// Расчет итоговой зарплаты с учетом комиссии
        /// </summary>
        /// <param name="salary">Исходная зарплата</param>
        /// <returns>Зарплата после вычета комиссии</returns>
        decimal Calculate(decimal salary);

        /// <summary>
        /// Получение названия банковского сервиса
        /// </summary>
        /// <returns>Название банка</returns>
        string GetServiceName();
    }

    /// <summary>
    /// Стратегия расчета зарплаты для Сбербанка (комиссия 1%)
    /// </summary>
    public class SberbankStrategy : ISalaryCalculationStrategy
    {
        /// <summary>
        /// Расчет зарплаты с учетом комиссии Сбербанка (1%)
        /// </summary>
        /// <param name="salary">Исходная зарплата</param>
        /// <returns>Зарплата после вычета 1% комиссии</returns>
        public decimal Calculate(decimal salary)
        {
            return salary * 0.99m; // минус 1%
        }

        /// <summary>
        /// Получение названия сервиса
        /// </summary>
        /// <returns>"Сбербанк"</returns>
        public string GetServiceName()
        {
            return "Сбербанк";
        }

        /// <summary>
        /// Строковое представление стратегии
        /// </summary>
        /// <returns>Строка с информацией о комиссии</returns>
        public override string ToString()
        {
            return "Сбербанк (комиссия 1%)";
        }
    }

    /// <summary>
    /// Стратегия расчета зарплаты для Газпромбанка (комиссия 1.5%)
    /// </summary>
    public class GazprombankStrategy : ISalaryCalculationStrategy
    {
        /// <summary>
        /// Расчет зарплаты с учетом комиссии Газпромбанка (1.5%)
        /// </summary>
        /// <param name="salary">Исходная зарплата</param>
        /// <returns>Зарплата после вычета 1.5% комиссии</returns>
        public decimal Calculate(decimal salary)
        {
            return salary * 0.985m; // минус 1.5%
        }

        /// <summary>
        /// Получение названия сервиса
        /// </summary>
        /// <returns>"Газпромбанк"</returns>
        public string GetServiceName()
        {
            return "Газпромбанк";
        }

        /// <summary>
        /// Строковое представление стратегии
        /// </summary>
        /// <returns>Строка с информацией о комиссии</returns>
        public override string ToString()
        {
            return "Газпромбанк (комиссия 1.5%)";
        }
    }
}
