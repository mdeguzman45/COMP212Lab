using System.ComponentModel;

namespace Marc_DeGuzman_Exercise03
{
    public class Bill_Detail : INotifyPropertyChanged
    {
        private int _quantity;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Category { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity {
            get
            {
                return _quantity;
            }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property)); //raise an event
            }
        }
    }
}
