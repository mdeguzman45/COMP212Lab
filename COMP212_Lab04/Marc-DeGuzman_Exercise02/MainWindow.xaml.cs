using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace Marc_DeGuzman_Exercise02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        // prices for dental services
        private readonly double flossPrice = 20.00;
        private readonly double fillPrice = 75.00;
        private readonly double rootCanalPrice = 150.00;

        private double initialBill = 0;

        private double ageDiscount = -1; // default to -1 for validation
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<string> _provinces = new ObservableCollection<string>();
        public ObservableCollection<string> Provinces {
            get { return _provinces; }
            set
            {
                _provinces = value;
                NotifyPropertyChanged();
            }
        }

        public string SelectedProvince { get; set; }
        public string PatientName { get; set; }
        public string PatientAddress { get; set; }

        private string _finalOutputString;
        public string FinalStringOutput { 
            get
            {
                return _finalOutputString;
            }
            set {
                _finalOutputString = value;
                NotifyPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            // add provinces combobox list
            Provinces.Add("Alberta");
            Provinces.Add("Ontario");
            Provinces.Add("Quebec");
        }

        // apply 10% discount for senior patients
        private void seniorRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ageDiscount = .1;
        }

        // apply 15% discount for kids/youth patients
        private void kidRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ageDiscount = .15;
        }

        // don't apply any discount for adult patients
        private void adultRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ageDiscount = 0;
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            string stringProvince = "Selected Province: " + SelectedProvince;

            // check for now if inputs are null
            if (PatientName == null)
            {
                MessageBox.Show("Please enter patient name", "Alert");
                return;
            }

            if (PatientAddress == null)
            {
                MessageBox.Show("Please enter patient address", "Alert");
                return;
            }

            if (ageDiscount == -1)
            {
                MessageBox.Show("Please select your age bracket", "Alert");
                return;
            }

            if (SelectedProvince == null)
            {
                MessageBox.Show("Please select a province", "Alert");
                return;
            }

            if (initialBill == 0)
            {
                MessageBox.Show("Please select Dental service performed", "Alert");
                return;
            }

            //string alertData = "Name: " + PatientName + "\nAddress: " + PatientAddress +
            //                    "\nProvince: " + SelectedProvince + "\nDiscount: " + ageDiscount.ToString() +
            //                    "\nInitial Computation: " + initialBill.ToString();

            //MessageBox.Show(alertData, "Alert");

            double gstPercentage;
            // get GST
            if (SelectedProvince.Equals("Alberta"))
            {
                gstPercentage = 0.07;
            } 
            else if (SelectedProvince.Equals("Ontario"))
            {
                gstPercentage = 0.13;
            }
            else // Quebec
            {
                gstPercentage = 0.06;
            }

            // compute gst and discount if applicable
            double gstValue = initialBill * gstPercentage;
            double initialBillWithGst = initialBill + gstValue;
            double discountValue = initialBillWithGst * ageDiscount;
            double totalBill = initialBillWithGst - discountValue;

            // String finalOutput = $"Patient Name:\t{PatientName}\nPatient Address:\t{PatientAddress}\nDiscount:\t{ageDiscount.ToString("P", CultureInfo.InvariantCulture)}\n";
            // finalOutput += $"GST:\t\t{gstPercentage.ToString("P", CultureInfo.InvariantCulture)}\nService Fees:\t{initialBill:C}";

            String finalOutput = $"Patient Name:\t{PatientName}\nPatient Address:\t{PatientAddress}\nService Fees:\t{initialBill:C}\n";
            finalOutput += $"GST:\t\t{gstValue:C}\nDiscount:\t{discountValue:C}\nTotal Bill:\t{totalBill:C}";
            FinalStringOutput = finalOutput;
        }

        // for the combobox provinces to be populated
        public void NotifyPropertyChanged([CallerMemberName] string propertyName="")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void dentalServices_CheckedChanged(object sender, RoutedEventArgs e)
        {
            double dentalComputation = 0; // set to 0 before adding checked items

            if (cbFloss.IsChecked == true)
            {
                dentalComputation += flossPrice;
            }

            if (cbFill.IsChecked == true)
            {
                dentalComputation += fillPrice;
            }

            if (cbRootCanal.IsChecked == true)
            {
                dentalComputation += rootCanalPrice;
            }

            // update initial bill for validation
            initialBill = dentalComputation;
        }
    }
}
