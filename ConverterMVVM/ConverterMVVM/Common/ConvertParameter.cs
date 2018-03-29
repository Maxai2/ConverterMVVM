using ConverterMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterMVVM.Common
{
    public class ConvertParameter
    {
        public Currence From { get; set; }
        public Currence To { get; set; }
        public decimal Value { get; set; }
        public decimal Answer { get; set; }
    }
}
