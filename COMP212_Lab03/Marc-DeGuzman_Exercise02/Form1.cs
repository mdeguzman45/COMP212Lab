using System;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marc_DeGuzman_Exercise02
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        // start an async Task to calculate for the factorial of a number
        private async void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // retrieve user input as an integer
                int number = int.Parse(factorialTextBox.Text);

                factorialOutputLabel.Text = "Calculating...";

                // Task to perform Factorial calculation in separate thread
                Task<BigInteger> factorialTask = Task.Run(() => factorial(number));

                // wait for Task in separate thread to complete
                await factorialTask;

                // display result after Task in separate thread completes
                 factorialOutputLabel.Text = factorialTask.Result.ToString();
            }
            catch (FormatException ex)
            {
                showMessage("Factorial input is not a number", "Error");
            }
            catch (ArgumentNullException ex)
            {
                showMessage(ex.Message, "Error");
            }
            catch (OverflowException ex)
            {
                showMessage(ex.Message, "Error");
            }

        }

        // compute factorial of a number recursively
        private BigInteger factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * factorial(n - 1);
        }

        // calculate interest synchronously
        private void calcInterestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // retrieve input loan amount
                double loanAmount = Double.Parse(loanAmountTextBox.Text);

                // retrieve interest rate input
                double interestRate = Double.Parse(interestRateTextBox.Text);

                // retrieve duration input (we are expected this in years 1/2/3/4/5...)
                int duration = int.Parse(durationTextBox.Text);

                interestRateOutputLabel.Text = "Calculating...";

                // simple calculation of interest
                var rateOfInterest = interestRate / 100;
                var calculatedInterest = loanAmount * duration * rateOfInterest;

                interestRateOutputLabel.Text = calculatedInterest.ToString("N2");
            }
            catch(FormatException ex)
            {
                showMessage(ex.Message, "Error");
            }
        }

        // show message to user
        private void showMessage(string alertMsg, string alertType)
        {
            MessageBoxIcon icon = alertType == "Error" ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(alertMsg, alertType, MessageBoxButtons.OK, icon);
        }
    }
}
