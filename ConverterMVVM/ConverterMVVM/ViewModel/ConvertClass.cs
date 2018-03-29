using ConverterMVVM.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ConverterMVVM.ViewModel
{
    public class Currence
    {
        public string Name { get; set; }
        public decimal Value { get; set; }

        public Currence(string Name, decimal Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
    }

    public class ConvertClass
    {
        public ObservableCollection<Currence> currencyItem { get; set; }

        public ConvertClass()
        {
            currencyItem = new ObservableCollection<Currence>()
            {
                new Currence("USD", 0.42M),
                new Currence("AZN", 0.72M),
                new Currence("RUB", 2.46M),
                new Currence("EUR", 0.34M)
            };
        }

        void Convert(ConvertParameter parameter)
        {
            //string From = parameter.From.Name;
            //string To = parameter.To.Name;

            if (parameter.From.Name == "USD" && parameter.To.Name == "AZN")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "USD" && parameter.To.Name == "RUB")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "USD" && parameter.To.Name == "EUR")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "AZN" && parameter.To.Name == "EUR")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "AZN" && parameter.To.Name == "USD")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "AZN" && parameter.To.Name == "RUB")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "RUB" && parameter.To.Name == "EUR")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "RUB" && parameter.To.Name == "USD")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "RUB" && parameter.To.Name == "AZN")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "EUR" && parameter.To.Name == "AZN")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "EUR" && parameter.To.Name == "USD")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
            else
            if (parameter.From.Name == "EUR" && parameter.To.Name == "RUB")
            {
                parameter.Answer = parameter.Value * parameter.To.Value;
            }
        }

        private ICommand convertCommand;
        public ICommand ConvertCommand
        {
            get
            {
                if (this.convertCommand is null)
                {
                    this.convertCommand = new RelayCommand(
                        (param) =>
                        {
                            var convertParam = param as ConvertParameter;

                            Convert(convertParam);
                        },
                        (param) =>
                        {
                            var checkParam = param as ConvertParameter;

                            if (checkParam.From == null || checkParam.To == null)
                                return false;

                            if (checkParam.From.Name != "" && checkParam.To.Name != "" && checkParam.Value != 0)
                            {
                                return true;
                            }
                            return false;
                        });
                }
                return this.convertCommand;
            }
        }
    }
}
