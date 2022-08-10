using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayCore_HW1
{
    public class Interest
    {  
        public double InterestAmount { get; set; }//Faize yatırılan para.
        public double TotalBalance { get; set; }//Bileşik faizi hesaplanmış ana para tutarı.
    }

}
