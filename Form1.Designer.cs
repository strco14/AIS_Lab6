namespace lab6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addEmployeeGroup = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.scientistPanel = new System.Windows.Forms.Panel();
            this.researchAreaLabel = new System.Windows.Forms.Label();
            this.researchAreaTextBox = new System.Windows.Forms.TextBox();
            this.publicationsLabel = new System.Windows.Forms.Label();
            this.publicationsTextBox = new System.Windows.Forms.TextBox();
            this.engineerPanel = new System.Windows.Forms.Panel();
            this.specializationLabel = new System.Windows.Forms.Label();
            this.specializationTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.bankLabel = new System.Windows.Forms.Label();
            this.bankComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.changeBankGroup = new System.Windows.Forms.GroupBox();
            this.selectEmployeeLabel = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.currentBankLabel = new System.Windows.Forms.Label();
            this.currentInfoLabel = new System.Windows.Forms.Label();
            this.newBankLabel = new System.Windows.Forms.Label();
            this.newBankComboBox = new System.Windows.Forms.ComboBox();
            this.changeBankButton = new System.Windows.Forms.Button();
            this.decoratorGroup = new System.Windows.Forms.GroupBox();
            this.decoratorTabControl = new System.Windows.Forms.TabControl();
            this.englishTab = new System.Windows.Forms.TabPage();
            this.employeeForDecorLabel = new System.Windows.Forms.Label();
            this.employeeForDecorComboBox = new System.Windows.Forms.ComboBox();
            this.certLabel = new System.Windows.Forms.Label();
            this.certTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.englishLevelLabel = new System.Windows.Forms.Label();
            this.englishLevelComboBox = new System.Windows.Forms.ComboBox();
            this.addEnglishButton = new System.Windows.Forms.Button();
            this.degreeTab = new System.Windows.Forms.TabPage();
            this.employeeForDegreeLabel = new System.Windows.Forms.Label();
            this.employeeForDegreeComboBox = new System.Windows.Forms.ComboBox();
            this.fieldLabel = new System.Windows.Forms.Label();
            this.fieldTextBox = new System.Windows.Forms.TextBox();
            this.topicLabel = new System.Windows.Forms.Label();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.addDegreeButton = new System.Windows.Forms.Button();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.statsLabel = new System.Windows.Forms.Label();
            this.positionStatsLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addPanel.SuspendLayout();
            this.addEmployeeGroup.SuspendLayout();
            this.scientistPanel.SuspendLayout();
            this.engineerPanel.SuspendLayout();
            this.changeBankGroup.SuspendLayout();
            this.decoratorGroup.SuspendLayout();
            this.decoratorTabControl.SuspendLayout();
            this.englishTab.SuspendLayout();
            this.degreeTab.SuspendLayout();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.addEmployeeGroup);
            this.addPanel.Controls.Add(this.changeBankGroup);
            this.addPanel.Controls.Add(this.decoratorGroup);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(1000, 529);
            this.addPanel.TabIndex = 0;
            // 
            // addEmployeeGroup
            // 
            this.addEmployeeGroup.Controls.Add(this.nameLabel);
            this.addEmployeeGroup.Controls.Add(this.nameTextBox);
            this.addEmployeeGroup.Controls.Add(this.salaryLabel);
            this.addEmployeeGroup.Controls.Add(this.salaryTextBox);
            this.addEmployeeGroup.Controls.Add(this.positionLabel);
            this.addEmployeeGroup.Controls.Add(this.positionComboBox);
            this.addEmployeeGroup.Controls.Add(this.scientistPanel);
            this.addEmployeeGroup.Controls.Add(this.engineerPanel);
            this.addEmployeeGroup.Controls.Add(this.bankLabel);
            this.addEmployeeGroup.Controls.Add(this.bankComboBox);
            this.addEmployeeGroup.Controls.Add(this.addButton);
            this.addEmployeeGroup.Location = new System.Drawing.Point(10, 10);
            this.addEmployeeGroup.Name = "addEmployeeGroup";
            this.addEmployeeGroup.Size = new System.Drawing.Size(500, 300);
            this.addEmployeeGroup.TabIndex = 0;
            this.addEmployeeGroup.TabStop = false;
            this.addEmployeeGroup.Text = "Добавить сотрудника";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(36, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(120, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(20, 60);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(66, 16);
            this.salaryLabel.TabIndex = 2;
            this.salaryLabel.Text = "Зарплата:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(120, 57);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(200, 22);
            this.salaryTextBox.TabIndex = 3;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(20, 90);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(76, 16);
            this.positionLabel.TabIndex = 4;
            this.positionLabel.Text = "Должность:";
            // 
            // positionComboBox
            // 
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(120, 87);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(200, 24);
            this.positionComboBox.TabIndex = 5;
            // 
            // scientistPanel
            // 
            this.scientistPanel.Controls.Add(this.researchAreaLabel);
            this.scientistPanel.Controls.Add(this.researchAreaTextBox);
            this.scientistPanel.Controls.Add(this.publicationsLabel);
            this.scientistPanel.Controls.Add(this.publicationsTextBox);
            this.scientistPanel.Location = new System.Drawing.Point(20, 120);
            this.scientistPanel.Name = "scientistPanel";
            this.scientistPanel.Size = new System.Drawing.Size(460, 60);
            this.scientistPanel.TabIndex = 10;
            this.scientistPanel.Visible = false;
            // 
            // researchAreaLabel
            // 
            this.researchAreaLabel.AutoSize = true;
            this.researchAreaLabel.Location = new System.Drawing.Point(10, 5);
            this.researchAreaLabel.Name = "researchAreaLabel";
            this.researchAreaLabel.Size = new System.Drawing.Size(149, 16);
            this.researchAreaLabel.TabIndex = 0;
            this.researchAreaLabel.Text = "Область исследований:";
            // 
            // researchAreaTextBox
            // 
            this.researchAreaTextBox.Location = new System.Drawing.Point(160, 2);
            this.researchAreaTextBox.Name = "researchAreaTextBox";
            this.researchAreaTextBox.Size = new System.Drawing.Size(200, 22);
            this.researchAreaTextBox.TabIndex = 1;
            // 
            // publicationsLabel
            // 
            this.publicationsLabel.AutoSize = true;
            this.publicationsLabel.Location = new System.Drawing.Point(10, 35);
            this.publicationsLabel.Name = "publicationsLabel";
            this.publicationsLabel.Size = new System.Drawing.Size(123, 16);
            this.publicationsLabel.TabIndex = 2;
            this.publicationsLabel.Text = "Кол-во публикаций:";
            // 
            // publicationsTextBox
            // 
            this.publicationsTextBox.Location = new System.Drawing.Point(160, 32);
            this.publicationsTextBox.Name = "publicationsTextBox";
            this.publicationsTextBox.Size = new System.Drawing.Size(80, 22);
            this.publicationsTextBox.TabIndex = 3;
            // 
            // engineerPanel
            // 
            this.engineerPanel.Controls.Add(this.specializationLabel);
            this.engineerPanel.Controls.Add(this.specializationTextBox);
            this.engineerPanel.Controls.Add(this.categoryLabel);
            this.engineerPanel.Controls.Add(this.categoryComboBox);
            this.engineerPanel.Location = new System.Drawing.Point(20, 120);
            this.engineerPanel.Name = "engineerPanel";
            this.engineerPanel.Size = new System.Drawing.Size(460, 60);
            this.engineerPanel.TabIndex = 11;
            this.engineerPanel.Visible = false;
            // 
            // specializationLabel
            // 
            this.specializationLabel.AutoSize = true;
            this.specializationLabel.Location = new System.Drawing.Point(10, 5);
            this.specializationLabel.Name = "specializationLabel";
            this.specializationLabel.Size = new System.Drawing.Size(103, 16);
            this.specializationLabel.TabIndex = 0;
            this.specializationLabel.Text = "Специализация:";
            // 
            // specializationTextBox
            // 
            this.specializationTextBox.Location = new System.Drawing.Point(160, 2);
            this.specializationTextBox.Name = "specializationTextBox";
            this.specializationTextBox.Size = new System.Drawing.Size(200, 22);
            this.specializationTextBox.TabIndex = 1;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(10, 35);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(71, 16);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Категория:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(160, 32);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(100, 24);
            this.categoryComboBox.TabIndex = 3;
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Location = new System.Drawing.Point(20, 120);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(125, 16);
            this.bankLabel.TabIndex = 6;
            this.bankLabel.Text = "Банк для зарплаты:";
            // 
            // bankComboBox
            // 
            this.bankComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankComboBox.FormattingEnabled = true;
            this.bankComboBox.Location = new System.Drawing.Point(140, 117);
            this.bankComboBox.Name = "bankComboBox";
            this.bankComboBox.Size = new System.Drawing.Size(200, 24);
            this.bankComboBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(140, 160);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 30);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить сотрудника";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // changeBankGroup
            // 
            this.changeBankGroup.Controls.Add(this.selectEmployeeLabel);
            this.changeBankGroup.Controls.Add(this.employeeComboBox);
            this.changeBankGroup.Controls.Add(this.currentBankLabel);
            this.changeBankGroup.Controls.Add(this.currentInfoLabel);
            this.changeBankGroup.Controls.Add(this.newBankLabel);
            this.changeBankGroup.Controls.Add(this.newBankComboBox);
            this.changeBankGroup.Controls.Add(this.changeBankButton);
            this.changeBankGroup.Location = new System.Drawing.Point(520, 10);
            this.changeBankGroup.Name = "changeBankGroup";
            this.changeBankGroup.Size = new System.Drawing.Size(460, 300);
            this.changeBankGroup.TabIndex = 1;
            this.changeBankGroup.TabStop = false;
            this.changeBankGroup.Text = "Изменить банк для сотрудника";
            // 
            // selectEmployeeLabel
            // 
            this.selectEmployeeLabel.AutoSize = true;
            this.selectEmployeeLabel.Location = new System.Drawing.Point(10, 25);
            this.selectEmployeeLabel.Name = "selectEmployeeLabel";
            this.selectEmployeeLabel.Size = new System.Drawing.Size(141, 16);
            this.selectEmployeeLabel.TabIndex = 0;
            this.selectEmployeeLabel.Text = "Выберите сотрудника:";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(170, 22);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(250, 24);
            this.employeeComboBox.TabIndex = 1;
            // 
            // currentBankLabel
            // 
            this.currentBankLabel.AutoSize = true;
            this.currentBankLabel.Location = new System.Drawing.Point(10, 60);
            this.currentBankLabel.Name = "currentBankLabel";
            this.currentBankLabel.Size = new System.Drawing.Size(160, 16);
            this.currentBankLabel.TabIndex = 2;
            this.currentBankLabel.Text = "Текущий банк: не выбран";
            // 
            // currentInfoLabel
            // 
            this.currentInfoLabel.AutoSize = true;
            this.currentInfoLabel.Location = new System.Drawing.Point(10, 85);
            this.currentInfoLabel.Name = "currentInfoLabel";
            this.currentInfoLabel.Size = new System.Drawing.Size(139, 16);
            this.currentInfoLabel.TabIndex = 3;
            this.currentInfoLabel.Text = "Доп. информация: нет";
            // 
            // newBankLabel
            // 
            this.newBankLabel.AutoSize = true;
            this.newBankLabel.Location = new System.Drawing.Point(10, 120);
            this.newBankLabel.Name = "newBankLabel";
            this.newBankLabel.Size = new System.Drawing.Size(81, 16);
            this.newBankLabel.TabIndex = 4;
            this.newBankLabel.Text = "Новый банк:";
            // 
            // newBankComboBox
            // 
            this.newBankComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newBankComboBox.FormattingEnabled = true;
            this.newBankComboBox.Location = new System.Drawing.Point(170, 117);
            this.newBankComboBox.Name = "newBankComboBox";
            this.newBankComboBox.Size = new System.Drawing.Size(200, 24);
            this.newBankComboBox.TabIndex = 5;
            // 
            // changeBankButton
            // 
            this.changeBankButton.Location = new System.Drawing.Point(170, 160);
            this.changeBankButton.Name = "changeBankButton";
            this.changeBankButton.Size = new System.Drawing.Size(120, 30);
            this.changeBankButton.TabIndex = 6;
            this.changeBankButton.Text = "Изменить банк";
            this.changeBankButton.UseVisualStyleBackColor = true;
            // 
            // decoratorGroup
            // 
            this.decoratorGroup.Controls.Add(this.decoratorTabControl);
            this.decoratorGroup.Location = new System.Drawing.Point(10, 320);
            this.decoratorGroup.Name = "decoratorGroup";
            this.decoratorGroup.Size = new System.Drawing.Size(970, 200);
            this.decoratorGroup.TabIndex = 2;
            this.decoratorGroup.TabStop = false;
            this.decoratorGroup.Text = "Добавить характеристики сотруднику";
            // 
            // decoratorTabControl
            // 
            this.decoratorTabControl.Controls.Add(this.englishTab);
            this.decoratorTabControl.Controls.Add(this.degreeTab);
            this.decoratorTabControl.Location = new System.Drawing.Point(10, 25);
            this.decoratorTabControl.Name = "decoratorTabControl";
            this.decoratorTabControl.SelectedIndex = 0;
            this.decoratorTabControl.Size = new System.Drawing.Size(950, 160);
            this.decoratorTabControl.TabIndex = 0;
            // 
            // englishTab
            // 
            this.englishTab.Controls.Add(this.employeeForDecorLabel);
            this.englishTab.Controls.Add(this.employeeForDecorComboBox);
            this.englishTab.Controls.Add(this.certLabel);
            this.englishTab.Controls.Add(this.certTextBox);
            this.englishTab.Controls.Add(this.dateLabel);
            this.englishTab.Controls.Add(this.datePicker);
            this.englishTab.Controls.Add(this.englishLevelLabel);
            this.englishTab.Controls.Add(this.englishLevelComboBox);
            this.englishTab.Controls.Add(this.addEnglishButton);
            this.englishTab.Location = new System.Drawing.Point(4, 25);
            this.englishTab.Name = "englishTab";
            this.englishTab.Padding = new System.Windows.Forms.Padding(3);
            this.englishTab.Size = new System.Drawing.Size(942, 131);
            this.englishTab.TabIndex = 0;
            this.englishTab.Text = "Английский";
            this.englishTab.UseVisualStyleBackColor = true;
            // 
            // employeeForDecorLabel
            // 
            this.employeeForDecorLabel.AutoSize = true;
            this.employeeForDecorLabel.Location = new System.Drawing.Point(10, 10);
            this.employeeForDecorLabel.Name = "employeeForDecorLabel";
            this.employeeForDecorLabel.Size = new System.Drawing.Size(74, 16);
            this.employeeForDecorLabel.TabIndex = 0;
            this.employeeForDecorLabel.Text = "Сотрудник:";
            // 
            // employeeForDecorComboBox
            // 
            this.employeeForDecorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeForDecorComboBox.FormattingEnabled = true;
            this.employeeForDecorComboBox.Location = new System.Drawing.Point(120, 7);
            this.employeeForDecorComboBox.Name = "employeeForDecorComboBox";
            this.employeeForDecorComboBox.Size = new System.Drawing.Size(250, 24);
            this.employeeForDecorComboBox.TabIndex = 1;
            // 
            // certLabel
            // 
            this.certLabel.AutoSize = true;
            this.certLabel.Location = new System.Drawing.Point(10, 45);
            this.certLabel.Name = "certLabel";
            this.certLabel.Size = new System.Drawing.Size(80, 16);
            this.certLabel.TabIndex = 2;
            this.certLabel.Text = "Сертификат:";
            // 
            // certTextBox
            // 
            this.certTextBox.Location = new System.Drawing.Point(120, 42);
            this.certTextBox.Name = "certTextBox";
            this.certTextBox.Size = new System.Drawing.Size(200, 22);
            this.certTextBox.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(10, 80);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 16);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Дата:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(120, 77);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(120, 22);
            this.datePicker.TabIndex = 5;
            // 
            // englishLevelLabel
            // 
            this.englishLevelLabel.AutoSize = true;
            this.englishLevelLabel.Location = new System.Drawing.Point(10, 115);
            this.englishLevelLabel.Name = "englishLevelLabel";
            this.englishLevelLabel.Size = new System.Drawing.Size(60, 16);
            this.englishLevelLabel.TabIndex = 7;
            this.englishLevelLabel.Text = "Уровень:";
            // 
            // englishLevelComboBox
            // 
            this.englishLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.englishLevelComboBox.FormattingEnabled = true;
            this.englishLevelComboBox.Items.AddRange(new object[] {
            "Beginner",
            "Elementary",
            "Pre-Intermediate",
            "Intermediate",
            "Upper-Intermediate",
            "Advanced",
            "Proficiency"});
            this.englishLevelComboBox.Location = new System.Drawing.Point(120, 112);
            this.englishLevelComboBox.Name = "englishLevelComboBox";
            this.englishLevelComboBox.Size = new System.Drawing.Size(120, 24);
            this.englishLevelComboBox.TabIndex = 8;
            // 
            // addEnglishButton
            // 
            this.addEnglishButton.Location = new System.Drawing.Point(350, 42);
            this.addEnglishButton.Name = "addEnglishButton";
            this.addEnglishButton.Size = new System.Drawing.Size(150, 30);
            this.addEnglishButton.TabIndex = 6;
            this.addEnglishButton.Text = "Добавить английский";
            this.addEnglishButton.UseVisualStyleBackColor = true;
            // 
            // degreeTab
            // 
            this.degreeTab.Controls.Add(this.employeeForDegreeLabel);
            this.degreeTab.Controls.Add(this.employeeForDegreeComboBox);
            this.degreeTab.Controls.Add(this.fieldLabel);
            this.degreeTab.Controls.Add(this.fieldTextBox);
            this.degreeTab.Controls.Add(this.topicLabel);
            this.degreeTab.Controls.Add(this.topicTextBox);
            this.degreeTab.Controls.Add(this.yearLabel);
            this.degreeTab.Controls.Add(this.yearTextBox);
            this.degreeTab.Controls.Add(this.addDegreeButton);
            this.degreeTab.Location = new System.Drawing.Point(4, 25);
            this.degreeTab.Name = "degreeTab";
            this.degreeTab.Padding = new System.Windows.Forms.Padding(3);
            this.degreeTab.Size = new System.Drawing.Size(942, 131);
            this.degreeTab.TabIndex = 1;
            this.degreeTab.Text = "Ученая степень";
            this.degreeTab.UseVisualStyleBackColor = true;
            // 
            // employeeForDegreeLabel
            // 
            this.employeeForDegreeLabel.AutoSize = true;
            this.employeeForDegreeLabel.Location = new System.Drawing.Point(10, 10);
            this.employeeForDegreeLabel.Name = "employeeForDegreeLabel";
            this.employeeForDegreeLabel.Size = new System.Drawing.Size(74, 16);
            this.employeeForDegreeLabel.TabIndex = 0;
            this.employeeForDegreeLabel.Text = "Сотрудник:";
            // 
            // employeeForDegreeComboBox
            // 
            this.employeeForDegreeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeForDegreeComboBox.FormattingEnabled = true;
            this.employeeForDegreeComboBox.Location = new System.Drawing.Point(120, 7);
            this.employeeForDegreeComboBox.Name = "employeeForDegreeComboBox";
            this.employeeForDegreeComboBox.Size = new System.Drawing.Size(250, 24);
            this.employeeForDegreeComboBox.TabIndex = 1;
            // 
            // fieldLabel
            // 
            this.fieldLabel.AutoSize = true;
            this.fieldLabel.Location = new System.Drawing.Point(10, 45);
            this.fieldLabel.Name = "fieldLabel";
            this.fieldLabel.Size = new System.Drawing.Size(91, 16);
            this.fieldLabel.TabIndex = 2;
            this.fieldLabel.Text = "Область наук:";
            // 
            // fieldTextBox
            // 
            this.fieldTextBox.Location = new System.Drawing.Point(120, 42);
            this.fieldTextBox.Name = "fieldTextBox";
            this.fieldTextBox.Size = new System.Drawing.Size(200, 22);
            this.fieldTextBox.TabIndex = 3;
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Location = new System.Drawing.Point(10, 80);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(120, 16);
            this.topicLabel.TabIndex = 4;
            this.topicLabel.Text = "Тема диссертации:";
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(120, 77);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(200, 22);
            this.topicTextBox.TabIndex = 5;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(10, 115);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(82, 16);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Год защиты:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(120, 112);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(80, 22);
            this.yearTextBox.TabIndex = 7;
            // 
            // addDegreeButton
            // 
            this.addDegreeButton.Location = new System.Drawing.Point(350, 42);
            this.addDegreeButton.Name = "addDegreeButton";
            this.addDegreeButton.Size = new System.Drawing.Size(150, 30);
            this.addDegreeButton.TabIndex = 8;
            this.addDegreeButton.Text = "Добавить степень";
            this.addDegreeButton.UseVisualStyleBackColor = true;
            // 
            // employeeListBox
            // 
            this.employeeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeListBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 14;
            this.employeeListBox.Location = new System.Drawing.Point(0, 529);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.ScrollAlwaysVisible = true;
            this.employeeListBox.Size = new System.Drawing.Size(1000, 161);
            this.employeeListBox.TabIndex = 1;
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.statsLabel);
            this.statsPanel.Controls.Add(this.positionStatsLabel);
            this.statsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statsPanel.Location = new System.Drawing.Point(0, 690);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(1000, 60);
            this.statsPanel.TabIndex = 2;
            // 
            // statsLabel
            // 
            this.statsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.statsLabel.Location = new System.Drawing.Point(0, 25);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(1000, 35);
            this.statsLabel.TabIndex = 1;
            this.statsLabel.Text = "Всего сотрудников: 0";
            this.statsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // positionStatsLabel
            // 
            this.positionStatsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.positionStatsLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.positionStatsLabel.Location = new System.Drawing.Point(0, 0);
            this.positionStatsLabel.Name = "positionStatsLabel";
            this.positionStatsLabel.Size = new System.Drawing.Size(1000, 25);
            this.positionStatsLabel.TabIndex = 0;
            this.positionStatsLabel.Text = "Исслед.: 0 | Лабор.: 0 | Учен.: 0 | Инж.: 0";
            this.positionStatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.employeeListBox);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.addPanel);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления сотрудниками";
            this.addPanel.ResumeLayout(false);
            this.addEmployeeGroup.ResumeLayout(false);
            this.addEmployeeGroup.PerformLayout();
            this.scientistPanel.ResumeLayout(false);
            this.scientistPanel.PerformLayout();
            this.engineerPanel.ResumeLayout(false);
            this.engineerPanel.PerformLayout();
            this.changeBankGroup.ResumeLayout(false);
            this.changeBankGroup.PerformLayout();
            this.decoratorGroup.ResumeLayout(false);
            this.decoratorTabControl.ResumeLayout(false);
            this.englishTab.ResumeLayout(false);
            this.englishTab.PerformLayout();
            this.degreeTab.ResumeLayout(false);
            this.degreeTab.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.GroupBox addEmployeeGroup;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Panel scientistPanel;
        private System.Windows.Forms.Label researchAreaLabel;
        private System.Windows.Forms.TextBox researchAreaTextBox;
        private System.Windows.Forms.Label publicationsLabel;
        private System.Windows.Forms.TextBox publicationsTextBox;
        private System.Windows.Forms.Panel engineerPanel;
        private System.Windows.Forms.Label specializationLabel;
        private System.Windows.Forms.TextBox specializationTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.ComboBox bankComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox changeBankGroup;
        private System.Windows.Forms.Label selectEmployeeLabel;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.Label currentBankLabel;
        private System.Windows.Forms.Label currentInfoLabel;
        private System.Windows.Forms.Label newBankLabel;
        private System.Windows.Forms.ComboBox newBankComboBox;
        private System.Windows.Forms.Button changeBankButton;
        private System.Windows.Forms.GroupBox decoratorGroup;
        private System.Windows.Forms.TabControl decoratorTabControl;
        private System.Windows.Forms.TabPage englishTab;
        private System.Windows.Forms.Label employeeForDecorLabel;
        private System.Windows.Forms.ComboBox employeeForDecorComboBox;
        private System.Windows.Forms.Label certLabel;
        private System.Windows.Forms.TextBox certTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label englishLevelLabel;
        private System.Windows.Forms.ComboBox englishLevelComboBox;
        private System.Windows.Forms.Button addEnglishButton;
        private System.Windows.Forms.TabPage degreeTab;
        private System.Windows.Forms.Label employeeForDegreeLabel;
        private System.Windows.Forms.ComboBox employeeForDegreeComboBox;
        private System.Windows.Forms.Label fieldLabel;
        private System.Windows.Forms.TextBox fieldTextBox;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button addDegreeButton;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Label positionStatsLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}