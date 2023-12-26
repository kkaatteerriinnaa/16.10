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
using System.ComponentModel;

namespace _16._10
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private double _numberA;
        private double _numberB;
        private double _result;

        public event PropertyChangedEventHandler PropertyChanged;

        public double NumberA
        {
            get { return _numberA; }
            set
            {
                _numberA = value;
                OnPropertyChanged("Result");
            }
        }

        public double NumberB
        {
            get { return _numberB; }
            set
            {
                _numberB = value;
                OnPropertyChanged("Result");
            }
        }

        public double Result
        {
            get { return _numberA + _numberB; }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
