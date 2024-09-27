namespace DebuggingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Double.TryParse(textBoxPrincipal.Text, out double principalAmount);
            Double.TryParse(textBoxInterestRate.Text, out double interestRate);

            double incomePerMonth = principalAmount * interestRate;

            labelOutput.Text = incomePerMonth.ToString();

        }
    }
}
