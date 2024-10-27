namespace WinFS_DZ_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            expenseNameLabel = new Label();
            expenseNameTextBox = new TextBox();
            expenseAmountLabel = new Label();
            expenseAmountNumeric = new NumericUpDown();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            addExpenseButton = new Button();
            totalExpenseLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)expenseAmountNumeric).BeginInit();
            SuspendLayout();
            // 
            // expenseNameLabel
            // 
            expenseNameLabel.AutoSize = true;
            expenseNameLabel.Location = new Point(53, 59);
            expenseNameLabel.Name = "expenseNameLabel";
            expenseNameLabel.Size = new Size(81, 15);
            expenseNameLabel.TabIndex = 0;
            expenseNameLabel.Text = "Назва витрат:";
            // 
            // expenseNameTextBox
            // 
            expenseNameTextBox.Location = new Point(140, 51);
            expenseNameTextBox.Name = "expenseNameTextBox";
            expenseNameTextBox.Size = new Size(100, 23);
            expenseNameTextBox.TabIndex = 1;
            // 
            // expenseAmountLabel
            // 
            expenseAmountLabel.AutoSize = true;
            expenseAmountLabel.Location = new Point(56, 101);
            expenseAmountLabel.Name = "expenseAmountLabel";
            expenseAmountLabel.Size = new Size(78, 15);
            expenseAmountLabel.TabIndex = 2;
            expenseAmountLabel.Text = "Сума витрат:";
            // 
            // expenseAmountNumeric
            // 
            expenseAmountNumeric.Location = new Point(140, 101);
            expenseAmountNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            expenseAmountNumeric.Name = "expenseAmountNumeric";
            expenseAmountNumeric.Size = new Size(120, 23);
            expenseAmountNumeric.TabIndex = 3;
            expenseAmountNumeric.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(72, 147);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(62, 15);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Категорія:";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Харчування", "Транспорт", "Розваги", "Покупки", "Інше" });
            categoryComboBox.Location = new Point(140, 144);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(121, 23);
            categoryComboBox.TabIndex = 5;
            // 
            // addExpenseButton
            // 
            addExpenseButton.Location = new Point(186, 184);
            addExpenseButton.Name = "addExpenseButton";
            addExpenseButton.Size = new Size(75, 23);
            addExpenseButton.TabIndex = 6;
            addExpenseButton.Text = "Додати витрати";
            addExpenseButton.UseVisualStyleBackColor = true;
            addExpenseButton.Click += addExpenseButton_Click;
            // 
            // totalExpenseLabel
            // 
            totalExpenseLabel.AutoSize = true;
            totalExpenseLabel.Location = new Point(12, 213);
            totalExpenseLabel.Name = "totalExpenseLabel";
            totalExpenseLabel.Size = new Size(160, 15);
            totalExpenseLabel.TabIndex = 7;
            totalExpenseLabel.Text = "Загальна сума витрат: 0 грн";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(totalExpenseLabel);
            Controls.Add(addExpenseButton);
            Controls.Add(categoryComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(expenseAmountNumeric);
            Controls.Add(expenseAmountLabel);
            Controls.Add(expenseNameTextBox);
            Controls.Add(expenseNameLabel);
            Name = "Form1";
            Text = "Калькулятор витрат";
            ((System.ComponentModel.ISupportInitialize)expenseAmountNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label expenseNameLabel;
        private TextBox expenseNameTextBox;
        private Label expenseAmountLabel;
        private NumericUpDown expenseAmountNumeric;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private Button addExpenseButton;
        private Label totalExpenseLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
