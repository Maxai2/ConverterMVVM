using ConverterMVVM.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ConverterMVVM.ViewModel
{
    //public class Currence
    //{
    //    public string Name { get; set; }
    //    public double Value { get; set; }

    //    public Currence(string Name, double Value)
    //    {
    //        this.Name = Name;
    //        this.Value = Value;
    //    }
    //}

    public class ConvertClass
    {
        public ObservableCollection<string> currencyItem { get; set; }

        public ConvertClass()
        {
            currencyItem = new ObservableCollection<string>()
            {
                "USD",
                "AZN",
                "RUB",
                "EUR"
            };
        }


        private void tbValue_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        void Convert(string FCur, string TCur, double value)
        {
            
        }

        private IComparable convertCommand;

        //public IComparable ConvertCommand
        
            //get
            //{
            //    if (this.convertCommand is null)
            //    {
            //        this.convertCommand = new RelayCommand(
            //            (param) => 
            //            {
                            
            //            }
            //            )
            //    }
            //}
            
        


    }
}
