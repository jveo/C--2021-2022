using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTrackerAssignment {


    public static class MyExtensions {


        public static string doubleToPercent(this Double percent) {
            return String.Format("{0}%", percent);
        }

        public static string doubleToCurrency(this Double currency) {
            return String.Format("${0}", currency);
        }

        public static string TelephoneFormatter(this String telephone) {
            return String.Format("{0: (###)-###-####}", telephone); 
        }


    }



}
