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
using MVVMLibrary;
using SerializationLibrary;

namespace SimpleCalculator
{
    public class CalculatorViewModel : BindableBase
    {
        private int _a;
        public int a
        {
            get { return _a; }
            set
            {
                a = value;
                OnPropertyChanged(nameof(a));
            }
        }

        private int _b;
        public int b
        {
            get { return _b; }
            set
            {
                b = value;
                OnPropertyChanged(nameof(b));
            }
        }

        private int _result;
        public int Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand minusCommand { get; set; }

        public CalculatorViewModel()
        {
            AddCommand = new BindableCommand(Add, CanCalculate);
            minusCommand = new BindableCommand(minus, CanCalculate);
        } 

        private bool CanCalculate()
        {
            return a != 0 && b != 0;
        }

        private void Add()
        {
            Result = a + b;
        }

        private void minus()
        {
            Result = a - b;
        }
    }
}