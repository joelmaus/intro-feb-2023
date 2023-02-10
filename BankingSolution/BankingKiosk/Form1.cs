using Banking.Domain;

namespace BankingKiosk
{
    public partial class Form1 : Form
    {
        BankAccount _account;
        public Form1()
        {
            InitializeComponent();
            _account = new BankAccount(new StandardBonusCalculator(new StandardBusinessClock(new SystemTime())));
            UpdateBalanceDisplay();
        }

        private void UpdateBalanceDisplay()
        {
            this.Text = $"You have a balance of {_account.GetBalance():c} Currently";
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DoTransaction(_account.Deposit);
        }

        private void DoTransaction(Action<decimal> op) //if called, needs to take a method that returns void and takes decimal argument
        {
            try
            {
                var amount = decimal.Parse(amountInput.Text);
                op(amount);
                UpdateBalanceDisplay();
            }
            catch (FormatException)
            {

                MessageBox.Show("Enter a number.", "Error on transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AccountOverdraftException)
            {
                
                MessageBox.Show("You don't have enough money.", "Error on transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                amountInput.SelectAll();
                amountInput.Focus();
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            DoTransaction(_account.Withdraw);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoTransaction(ShowMessage);
        }

        private void ShowMessage(decimal amount) //shows text box with input box amount
        {
            MessageBox.Show("You clicked. Amount is " + amount.ToString("c"));
        }
    }
}