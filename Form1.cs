namespace WinFS_DZ_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private decimal totalExpense = 0;
        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(expenseNameTextBox.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву витрат.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть категорію.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string expenseName = expenseNameTextBox.Text;
            decimal expenseAmount = expenseAmountNumeric.Value;
            string category = categoryComboBox.SelectedItem.ToString();
            totalExpense += expenseAmount;
            totalExpenseLabel.Text = $"Загальна сума витрат: {totalExpense} грн";
            MessageBox.Show($"Витрати додано: {expenseName}, Сума: {expenseAmount} грн, Категорія: {category}", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = $"Калькулятор витрат - Час: {DateTime.Now:HH:mm:ss}";
        }
    }
}
