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
            this.Text = $"You have a balance of {_account.GetBalance():c} Currently";
        }

        private void depositButton_Click(object sender, EventArgs e)
        {

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {

        }
    }
}