using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        private List<Employee> employees = new List<Employee>();
        private Dictionary<string, ISalaryCalculationStrategy> strategies;
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        /// <summary>
        /// Инициализация формы и её компонентов
        /// </summary>
        private void InitializeForm()
        {
            this.Text = "Система управления сотрудниками с индивидуальными банками";
            this.Size = new Size(1000, 750);

            // Инициализация стратегий
            strategies = new Dictionary<string, ISalaryCalculationStrategy>
            {
                { "Сбербанк (1%)", new SberbankStrategy() },
                { "Газпромбанк (1.5%)", new GazprombankStrategy() }
            };

            InitializeAdditionalComponents();
            LoadSampleData();
        }

        /// <summary>
        /// Инициализация дополнительных компонентов
        /// </summary>
        private void InitializeAdditionalComponents()
        {

            positionComboBox.Items.AddRange(new[] {
                "Исследователь",
                "Лаборант",
                "Ученый",
                "Инженер"
            });
            positionComboBox.SelectedIndex = 0;

            bankComboBox.Items.AddRange(new string[] { "Сбербанк (1%)", "Газпромбанк (1.5%)" });
            bankComboBox.SelectedIndex = 0;

            newBankComboBox.Items.AddRange(new string[] { "Сбербанк (1%)", "Газпромбанк (1.5%)" });
            newBankComboBox.SelectedIndex = 0;

            categoryComboBox.Items.AddRange(new[] { "I", "II", "III", "IV", "V" });
            categoryComboBox.SelectedIndex = 2;

            // Настройка видимости панелей
            scientistPanel.Visible = false;
            engineerPanel.Visible = false;

            // Установка значений по умолчанию
            researchAreaTextBox.Text = "Физика";
            publicationsTextBox.Text = "0";
            specializationTextBox.Text = "Программирование";

            SetupValidation();


            positionComboBox.SelectedIndexChanged += PositionComboBox_SelectedIndexChanged;
            addButton.Click += AddButton_Click;
            changeBankButton.Click += ChangeBankButton_Click;
            addEnglishButton.Click += AddEnglishButton_Click;
            addDegreeButton.Click += AddDegreeButton_Click;
            employeeListBox.SelectedIndexChanged += EmployeeListBox_SelectedIndexChanged;
            employeeComboBox.SelectedIndexChanged += EmployeeComboBox_SelectedIndexChanged;

            UpdateControlPositions(positionComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Настройка валидации ввода для всех текстовых полей
        /// </summary>
        private void SetupValidation()
        {
            // Имя - только буквы, пробелы и дефисы (только KeyPress)
            nameTextBox.KeyPress += TextBox_OnlyTextKeyPress;

            // Зарплата - только цифры и одна запятая/точка (только KeyPress)
            salaryTextBox.KeyPress += TextBox_NumericKeyPress;

            // Область исследований - только текст (только KeyPress)
            researchAreaTextBox.KeyPress += TextBox_OnlyTextKeyPress;

            // Количество публикаций - только цифры (только KeyPress)
            publicationsTextBox.KeyPress += TextBox_OnlyDigitsKeyPress;

            // Специализация - только текст (только KeyPress)
            specializationTextBox.KeyPress += TextBox_OnlyTextKeyPress;

            // Тема диссертации - текст (только KeyPress)
            topicTextBox.KeyPress += TextBox_OnlyTextKeyPress;

            // Область наук - текст (только KeyPress)
            fieldTextBox.KeyPress += TextBox_OnlyTextKeyPress;

            // Год защиты - только цифры (только KeyPress)
            yearTextBox.KeyPress += TextBox_OnlyDigitsKeyPress;

            // Сертификат - текст (только KeyPress)
            certTextBox.KeyPress += TextBox_OnlyTextKeyPress;

            // Убираем AutoValidate чтобы не блокировать закрытие формы
            this.AutoValidate = AutoValidate.Disable;
        }


        /// <summary>
        /// Обработчик нажатия клавиш для текстовых полей (только буквы и разрешенные символы)
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события нажатия клавиши</param>
        private void TextBox_OnlyTextKeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем управляющие символы (Backspace, Delete и т.д.)
            if (char.IsControl(e.KeyChar))
                return;


            bool isRussianLetter = (e.KeyChar >= 'А' && e.KeyChar <= 'я') ||
                                  e.KeyChar == 'Ё' || e.KeyChar == 'ё';


            bool isEnglishLetter = (e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                                  (e.KeyChar >= 'a' && e.KeyChar <= 'z');


            bool isAllowedSymbol = e.KeyChar == ' ' || e.KeyChar == '-' || e.KeyChar == '\'' ||
                                  e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == ';';

            // Если символ не соответствует ни одному разрешенному типу, блокируем ввод
            if (!isRussianLetter && !isEnglishLetter && !isAllowedSymbol)
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        /// <summary>
        /// Обработчик нажатия клавиш для полей с только цифрами
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события нажатия клавиши</param>
        private void TextBox_OnlyDigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем управляющие символы
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        /// <summary>
        /// Обработчик нажатия клавиш для числовых полей (с десятичной точкой)
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события нажатия клавиши</param>
        private void TextBox_NumericKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Разрешаем управляющие символы
            if (char.IsControl(e.KeyChar))
                return;
            if (char.IsDigit(e.KeyChar))
                return;

            // Разрешаем одну запятую или точку (для десятичных чисел)
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                // Проверяем, нет ли уже разделителя в тексте
                if (textBox.Text.Contains(",") || textBox.Text.Contains("."))
                {
                    e.Handled = true;
                    System.Media.SystemSounds.Beep.Play();
                }
                return;
            }

            // Блокируем все остальные символы
            e.Handled = true;
            System.Media.SystemSounds.Beep.Play();
        }


        /// <summary>
        /// Обработчик изменения выбранной должности
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string position = positionComboBox.SelectedItem?.ToString() ?? "Исследователь";
            UpdateControlPositions(position);
        }

        /// <summary>
        /// Обновление позиций элементов управления в зависимости от выбранной должности
        /// </summary>
        /// <param name="position">Выбранная должность сотрудника</param>
        private void UpdateControlPositions(string position)
        {
            scientistPanel.Visible = (position == "Ученый");
            engineerPanel.Visible = (position == "Инженер");

            int baseY = 120;

            if (position == "Ученый")
            {
                scientistPanel.Location = new Point(20, baseY);
                scientistPanel.Visible = true;
                engineerPanel.Visible = false;

                bankLabel.Location = new Point(20, baseY + 70);
                bankComboBox.Location = new Point(140, baseY + 67);
                addButton.Location = new Point(140, baseY + 110);

                addEmployeeGroup.Height = baseY + 150;
            }
            else if (position == "Инженер")
            {
                engineerPanel.Location = new Point(20, baseY);
                engineerPanel.Visible = true;
                scientistPanel.Visible = false;

                bankLabel.Location = new Point(20, baseY + 70);
                bankComboBox.Location = new Point(140, baseY + 67);
                addButton.Location = new Point(140, baseY + 110);

                addEmployeeGroup.Height = baseY + 150;
            }
            else
            {
                scientistPanel.Visible = false;
                engineerPanel.Visible = false;

                bankLabel.Location = new Point(20, baseY);
                bankComboBox.Location = new Point(140, baseY - 3);
                addButton.Location = new Point(140, baseY + 40);

                addEmployeeGroup.Height = baseY + 80;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Ручная валидация при добавлении сотрудника
            if (!ValidateInputForAdding())
            {
                return;
            }

            decimal salary = decimal.Parse(salaryTextBox.Text.Replace('.', ','));
            Employee employee;

            string position = positionComboBox.SelectedItem.ToString();

            switch (position)
            {
                case "Исследователь":
                    employee = new Researcher(nameTextBox.Text.Trim(), salary);
                    break;
                case "Лаборант":
                    employee = new LabAssistant(nameTextBox.Text.Trim(), salary);
                    break;
                case "Ученый":
                    employee = new Scientist(
                        nameTextBox.Text.Trim(),
                        salary,
                        researchAreaTextBox.Text.Trim(),
                        int.Parse(publicationsTextBox.Text)
                    );
                    break;
                case "Инженер":
                    employee = new Engineer(
                        nameTextBox.Text.Trim(),
                        salary,
                        specializationTextBox.Text.Trim(),
                        categoryComboBox.SelectedItem.ToString()
                    );
                    break;
                default:
                    employee = new Researcher(nameTextBox.Text.Trim(), salary);
                    break;
            }


            string selectedBank = bankComboBox.SelectedItem.ToString();
            if (strategies.ContainsKey(selectedBank))
            {
                employee.SetSalaryStrategy(strategies[selectedBank]);
            }

            employees.Add(employee);
            UpdateEmployeeList();


            nameTextBox.Clear();
            salaryTextBox.Clear();

            if (position == "Ученый")
            {
                researchAreaTextBox.Text = "Физика";
                publicationsTextBox.Text = "0";
            }
            else if (position == "Инженер")
            {
                specializationTextBox.Text = "Программирование";
            }

            MessageBox.Show("Сотрудник успешно добавлен!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Валидация входных данных перед добавлением сотрудника
        /// </summary>
        /// <returns>True если все данные корректны, иначе False</returns>
        private bool ValidateInputForAdding()
        {
            // Проверка имени
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Введите имя сотрудника", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTextBox.Focus();
                return false;
            }

            if (nameTextBox.Text.Length < 2)
            {
                MessageBox.Show("Имя должно содержать минимум 2 символа", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTextBox.Focus();
                return false;
            }

            // Проверка зарплаты
            if (string.IsNullOrWhiteSpace(salaryTextBox.Text))
            {
                MessageBox.Show("Введите зарплату", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                salaryTextBox.Focus();
                return false;
            }

            if (!decimal.TryParse(salaryTextBox.Text.Replace('.', ','), out decimal salary))
            {
                MessageBox.Show("Введите корректное число для зарплаты", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                salaryTextBox.Focus();
                return false;
            }

            if (salary <= 0)
            {
                MessageBox.Show("Зарплата должна быть больше 0", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                salaryTextBox.Focus();
                return false;
            }

            if (salary > 1000000)
            {
                MessageBox.Show("Зарплата слишком большая (максимум 1,000,000)", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                salaryTextBox.Focus();
                return false;
            }

            string position = positionComboBox.SelectedItem.ToString();

            // Дополнительные проверки для Ученого
            if (position == "Ученый")
            {
                if (string.IsNullOrWhiteSpace(researchAreaTextBox.Text))
                {
                    MessageBox.Show("Введите область исследований для ученого", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    researchAreaTextBox.Focus();
                    return false;
                }

                if (researchAreaTextBox.Text.Length < 3)
                {
                    MessageBox.Show("Область исследований должна содержать минимум 3 символа", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    researchAreaTextBox.Focus();
                    return false;
                }

                if (!int.TryParse(publicationsTextBox.Text, out int publications))
                {
                    MessageBox.Show("Введите корректное количество публикаций", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    publicationsTextBox.Focus();
                    return false;
                }

                if (publications < 0)
                {
                    MessageBox.Show("Количество публикаций не может быть отрицательным", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    publicationsTextBox.Focus();
                    return false;
                }
            }

            // Дополнительные проверки для Инженера
            if (position == "Инженер")
            {
                if (string.IsNullOrWhiteSpace(specializationTextBox.Text))
                {
                    MessageBox.Show("Введите специализацию для инженера", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    specializationTextBox.Focus();
                    return false;
                }

                if (specializationTextBox.Text.Length < 3)
                {
                    MessageBox.Show("Специализация должна содержать минимум 3 символа", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    specializationTextBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ChangeBankButton_Click(object sender, EventArgs e)
        {
            if (employeeComboBox.SelectedIndex >= 0)
            {
                int index = employeeComboBox.SelectedIndex;
                string selectedBank = newBankComboBox.SelectedItem.ToString();

                if (strategies.ContainsKey(selectedBank))
                {
                    employees[index].SetSalaryStrategy(strategies[selectedBank]);
                    currentBankLabel.Text = $"Текущий банк: {employees[index].GetStrategyName()}";
                    UpdateEmployeeList();
                    MessageBox.Show($"Банк успешно изменен на {selectedBank}", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите сотрудника", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить английский"
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void AddEnglishButton_Click(object sender, EventArgs e)
        {
            if (employeeForDecorComboBox.SelectedIndex >= 0)
            {
                int index = employeeForDecorComboBox.SelectedIndex;
                Employee employee = employees[index];

                if (!string.IsNullOrWhiteSpace(certTextBox.Text))
                {
                    // Получаем выбранный уровень английского
                    string selectedLevel = "Intermediate";
                    if (englishLevelComboBox.SelectedItem != null)
                    {
                        selectedLevel = englishLevelComboBox.SelectedItem.ToString();
                    }

                    // СОЗДАЕМ ДЕКОРАТОР с выбранным уровнем
                    Employee decorated = new EnglishSkillDecorator(
                        employee,
                        certTextBox.Text.Trim(),
                        datePicker.Value,
                        selectedLevel);

                    // Сохраняем банковскую стратегию
                    decorated.SetSalaryStrategy(employee.SalaryStrategy);

                    employees[index] = decorated;
                    UpdateEmployeeList();

                    // Очищаем поля, но оставляем уровень по умолчанию
                    certTextBox.Clear();
                    englishLevelComboBox.SelectedIndex = 3; // Intermediate

                    MessageBox.Show($"Английский язык успешно добавлен (уровень: {selectedLevel})", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Введите название сертификата", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить степень"
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void AddDegreeButton_Click(object sender, EventArgs e)
        {
            if (employeeForDegreeComboBox.SelectedIndex >= 0)
            {
                if (!ValidateYearForAdding())
                    return;

                int index = employeeForDegreeComboBox.SelectedIndex;
                Employee employee = employees[index];

                if (!string.IsNullOrWhiteSpace(fieldTextBox.Text) &&
                    !string.IsNullOrWhiteSpace(topicTextBox.Text))
                {
                    Employee decorated = new AcademicDegreeDecorator(
                        employee,
                        fieldTextBox.Text.Trim(),
                        topicTextBox.Text.Trim(),
                        int.Parse(yearTextBox.Text));

                    // Сохраняем банковскую стратегию
                    decorated.SetSalaryStrategy(employee.SalaryStrategy);

                    employees[index] = decorated;
                    UpdateEmployeeList();
                    fieldTextBox.Clear();
                    topicTextBox.Clear();
                    yearTextBox.Clear();
                    MessageBox.Show("Ученая степень успешно добавлена", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Валидация года защиты для ученой степени
        /// </summary>
        /// <returns>True если год корректный, иначе False</returns>
        private bool ValidateYearForAdding()
        {
            if (string.IsNullOrWhiteSpace(yearTextBox.Text))
            {
                MessageBox.Show("Введите год защиты", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                yearTextBox.Focus();
                return false;
            }

            if (!int.TryParse(yearTextBox.Text, out int year))
            {
                MessageBox.Show("Введите корректный год", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                yearTextBox.Focus();
                return false;
            }

            int currentYear = DateTime.Now.Year;
            if (year < 1900 || year > currentYear)
            {
                MessageBox.Show($"Год должен быть между 1900 и {currentYear}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                yearTextBox.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в списке сотрудников
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void EmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeListBox.SelectedIndex >= 0)
            {
                employeeComboBox.SelectedIndex = employeeListBox.SelectedIndex;
                employeeForDecorComboBox.SelectedIndex = employeeListBox.SelectedIndex;
                employeeForDegreeComboBox.SelectedIndex = employeeListBox.SelectedIndex;
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного сотрудника в комбобоксе
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void EmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeComboBox.SelectedIndex >= 0)
            {
                int index = employeeComboBox.SelectedIndex;
                currentBankLabel.Text = $"Текущий банк: {employees[index].GetStrategyName()}";
                currentInfoLabel.Text = $"Должность: {employees[index].Position}";

                // Установить соответствующий банк в выпадающем списке
                for (int i = 0; i < newBankComboBox.Items.Count; i++)
                {
                    if (newBankComboBox.Items[i].ToString().Contains(employees[index].GetStrategyName()))
                    {
                        newBankComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Загрузка тестовых данных для демонстрации работы приложения
        /// </summary>
        private void LoadSampleData()
        {
            // Загрузка тестовых данных с разными банками
            var emp1 = new Researcher("Иванов Иван", 50000);
            emp1.SetSalaryStrategy(strategies["Сбербанк (1%)"]);
            employees.Add(emp1);

            var emp2 = new LabAssistant("Петрова Анна", 35000);
            emp2.SetSalaryStrategy(strategies["Газпромбанк (1.5%)"]);
            employees.Add(emp2);

            // Новый ученый
            var emp3 = new Scientist("Сидоров Алексей", 65000, "Квантовая физика", 12);
            emp3.SetSalaryStrategy(strategies["Сбербанк (1%)"]);
            employees.Add(emp3);

            // Новый инженер
            var emp4 = new Engineer("Кузнецов Михаил", 55000, "Электроника", "IV");
            emp4.SetSalaryStrategy(strategies["Газпромбанк (1.5%)"]);
            employees.Add(emp4);

            UpdateEmployeeList();
        }

        /// <summary>
        /// Обновление списка сотрудников и статистики
        /// </summary>
        private void UpdateEmployeeList()
        {
            if (employeeListBox == null) return;

            employeeListBox.Items.Clear();
            employeeComboBox.Items.Clear();
            employeeForDecorComboBox.Items.Clear();
            employeeForDegreeComboBox.Items.Clear();

            // Статистика по должностям
            var positionCount = new Dictionary<string, int>
            {
                { "Исследователь", 0 },
                { "Лаборант", 0 },
                { "Ученый", 0 },
                { "Инженер", 0 }
            };

            foreach (var employee in employees)
            {
                decimal netSalary = employee.CalculateSalary();
                decimal commission = employee.Salary - netSalary;
                decimal commissionPercent = (commission / employee.Salary) * 100;

                string info = $"{employee.GetInfo()} | Зарплата: {employee.Salary:C} → {netSalary:C} (комиссия: {commission:C} ≈ {commissionPercent:F2}%) | Банк: {employee.GetStrategyName()}";
                employeeListBox.Items.Add(info);
                employeeComboBox.Items.Add($"{employee.Name} ({employee.Position})");
                employeeForDecorComboBox.Items.Add($"{employee.Name} ({employee.Position})");
                employeeForDegreeComboBox.Items.Add($"{employee.Name} ({employee.Position})");

                // Собираем статистику
                if (positionCount.ContainsKey(employee.Position))
                {
                    positionCount[employee.Position]++;
                }
            }

            if (employeeComboBox.Items.Count > 0)
            {
                employeeComboBox.SelectedIndex = 0;
            }

            if (employeeForDecorComboBox.Items.Count > 0)
            {
                employeeForDecorComboBox.SelectedIndex = 0;
            }

            if (employeeForDegreeComboBox.Items.Count > 0)
            {
                employeeForDegreeComboBox.SelectedIndex = 0;
            }

            // Обновление статистики
            statsLabel.Text = $"Всего сотрудников: {employees.Count}";
            positionStatsLabel.Text = $"Исслед.: {positionCount["Исследователь"]} | Лабор.: {positionCount["Лаборант"]} | Учен.: {positionCount["Ученый"]} | Инж.: {positionCount["Инженер"]}";
        }
    }
}