using System;
namespace lab6
{
    /// <summary>
    /// Абстрактный базовый класс для всех сотрудников
    /// </summary>
    public abstract class Employee
    {
            public string Name { get; set; }

            public string Position { get; set; }

            public decimal Salary { get; set; }

            public ISalaryCalculationStrategy SalaryStrategy { get; set; }


            public Employee()
            {
                // По умолчанию Сбербанк
                SalaryStrategy = new SberbankStrategy();
            }

            /// <summary>
            /// Получение информации о сотруднике
            /// </summary>
            /// <returns>Строка с информацией о сотруднике</returns>
            public abstract string GetInfo();

            /// <summary>
            /// Расчет итоговой зарплаты с учетом банковской комиссии
            /// </summary>
            /// <returns>Итоговая зарплата после вычета комиссии</returns>
            public virtual decimal CalculateSalary()
            {
                return SalaryStrategy.Calculate(Salary);
            }

            /// <summary>
            /// Установка стратегии расчета зарплаты (смена банка)
            /// </summary>
            /// <param name="strategy">Новая стратегия расчета зарплаты</param>
            public virtual void SetSalaryStrategy(ISalaryCalculationStrategy strategy)
            {
                SalaryStrategy = strategy;
            }

            /// <summary>
            /// Получение названия текущей стратегии (банка)
            /// </summary>
            /// <returns>Название банка</returns>
            public string GetStrategyName()
            {
                return SalaryStrategy?.GetServiceName() ?? "Стратегия не выбрана";
            }
        }

        /// <summary>
        /// Класс исследователя
        /// </summary>
        public class Researcher : Employee
        {
            public Researcher(string name, decimal salary)
            {
                Name = name;
                Position = "Исследователь";
                Salary = salary;
            }

            /// <summary>
            /// Получение информации об исследователе
            /// </summary>
            /// <returns>Строка с информацией об исследователе</returns>
            public override string GetInfo()
            {
                return $"{Position}: {Name}";
            }
        }

        /// <summary>
        /// Класс лаборанта
        /// </summary>
        public class LabAssistant : Employee
        {

            public LabAssistant(string name, decimal salary)
            {
                Name = name;
                Position = "Лаборант";
                Salary = salary;
            }

            /// <summary>
            /// Получение информации о лаборанте
            /// </summary>
            /// <returns>Строка с информацией о лаборанте</returns>
            public override string GetInfo()
            {
                return $"{Position}: {Name}";
            }
        }

        /// <summary>
        /// Класс ученого
        /// </summary>
        public class Scientist : Employee
        {

            public string ResearchArea { get; set; }

            public int PublicationsCount { get; set; }

            public Scientist(string name, decimal salary, string researchArea = "Общая наука", int publicationsCount = 0)
            {
                Name = name;
                Position = "Ученый";
                Salary = salary;
                ResearchArea = researchArea;
                PublicationsCount = publicationsCount;
            }

            /// <summary>
            /// Получение информации об ученом
            /// </summary>
            /// <returns>Строка с информацией об ученом</returns>
            public override string GetInfo()
            {
                return $"{Position}: {Name}, Область исследований: {ResearchArea}, Публикаций: {PublicationsCount}";
            }
        }

        /// <summary>
        /// Класс инженера
        /// </summary>
        public class Engineer : Employee
        {

            public string Specialization { get; set; }


            public string Category { get; set; }


            public Engineer(string name, decimal salary, string specialization = "Общее машиностроение", string category = "III")
            {
                Name = name;
                Position = "Инженер";
                Salary = salary;
                Specialization = specialization;
                Category = category;
            }

            /// <summary>
            /// Получение информации об инженере
            /// </summary>
            /// <returns>Строка с информацией об инженере</returns>
            public override string GetInfo()
            {
                return $"{Position}: {Name}, Специализация: {Specialization}, Категория: {Category}";
            }
        }

        /// <summary>
        /// Абстрактный класс декоратора сотрудника (паттерн Декоратор)
        /// </summary>
        public abstract class EmployeeDecorator : Employee
        {

            protected Employee _employee;


            public EmployeeDecorator(Employee employee)
            {
                _employee = employee;
                Name = employee.Name;
                Position = employee.Position;
                Salary = employee.Salary;
                SalaryStrategy = employee.SalaryStrategy;
            }

            /// <summary>
            /// Получение информации о декорируемом сотруднике
            /// </summary>
            /// <returns>Строка с информацией о сотруднике</returns>
            public override string GetInfo()
            {
                return _employee.GetInfo();
            }

            /// <summary>
            /// Расчет зарплаты декорируемого сотрудника
            /// </summary>
            /// <returns>Итоговая зарплата после вычета комиссии</returns>
            public override decimal CalculateSalary()
            {
                return SalaryStrategy.Calculate(Salary);
            }

            /// <summary>
            /// Установка стратегии расчета зарплаты для декорируемого сотрудника
            /// </summary>
            /// <param name="strategy">Новая стратегия расчета зарплаты</param>
            public override void SetSalaryStrategy(ISalaryCalculationStrategy strategy)
            {
                SalaryStrategy = strategy;
            }
        }

        /// <summary>
        /// Декоратор для добавления знания английского языка
        /// </summary>
        public class EnglishSkillDecorator : EmployeeDecorator
        {

            public string CertificateName { get; set; }

            public DateTime? CertificateDate { get; set; }

            public string Level { get; set; }

            /// <summary>
            /// Конструктор декоратора знания английского
            /// </summary>
            /// <param name="employee">Сотрудник для декорирования</param>
            /// <param name="certificateName">Название сертификата</param>
            /// <param name="certificateDate">Дата получения сертификата</param>
            /// <param name="level">Уровень владения языком</param>
            public EnglishSkillDecorator(Employee employee, string certificateName,
                                        DateTime? certificateDate, string level = "Intermediate")
                : base(employee)
            {
                CertificateName = certificateName;
                CertificateDate = certificateDate;
                Level = level;
            }

            /// <summary>
            /// Получение информации о сотруднике с добавлением информации об английском
            /// </summary>
            /// <returns>Строка с расширенной информацией о сотруднике</returns>
            public override string GetInfo()
            {
                string certInfo = CertificateDate.HasValue ?
                    $" (сертификат '{CertificateName}' от {CertificateDate.Value.ToShortDateString()})" :
                    $" (сертификат '{CertificateName}')";

                return $"{_employee.GetInfo()}, Английский: {Level}{certInfo}";
            }
        }

        /// <summary>
        /// Декоратор для добавления ученой степени
        /// </summary>
        public class AcademicDegreeDecorator : EmployeeDecorator
        {
            /// <summary>
            /// Область наук
            /// </summary>
            public string ScienceField { get; set; }

            /// <summary>
            /// Тема диссертационной работы
            /// </summary>
            public string DissertationTopic { get; set; }

            /// <summary>
            /// Год защиты диссертации
            /// </summary>
            public int DefenseYear { get; set; }

            /// <summary>
            /// Конструктор декоратора ученой степени
            /// </summary>
            /// <param name="employee">Сотрудник для декорирования</param>
            /// <param name="scienceField">Область наук</param>
            /// <param name="dissertationTopic">Тема диссертации</param>
            /// <param name="defenseYear">Год защиты</param>
            public AcademicDegreeDecorator(Employee employee, string scienceField,
                                          string dissertationTopic, int defenseYear)
                : base(employee)
            {
                ScienceField = scienceField;
                DissertationTopic = dissertationTopic;
                DefenseYear = defenseYear;
            }

            /// <summary>
            /// Получение информации о сотруднике с добавлением информации об ученой степени
            /// </summary>
            /// <returns>Строка с расширенной информацией о сотруднике</returns>
            public override string GetInfo()
            {
                return $"{_employee.GetInfo()}, Ученая степень: {ScienceField} (тема: '{DissertationTopic}', год защиты: {DefenseYear})";
            }
        }
    }