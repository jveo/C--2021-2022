using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTrackerAssignment {
    class PreferredCustomer : Customer { 
        int id;
        bool mailingList;


        public double moneySpent {
            get;
            set;
        }

        public double discountLevel {
            get;
            set;
        }

       

        public PreferredCustomer(string name, string address, string telephone, int id, bool mailingList) : 
            base(name, address, telephone, id, mailingList) {
            //this.moneySpent = moneySpent;
        }

        public void discountAmt() {

            if (moneySpent > 2000) {
                discountLevel = 10;
                
            }

            if (moneySpent > 1500 && moneySpent < 1999) {
                discountLevel = 7;
                
            }

            if (moneySpent > 1000 && moneySpent < 1499) {
                discountLevel = 7;
                
            }

            if (moneySpent > 500 && moneySpent < 999) {
                discountLevel = 7;
               
            }

            if (moneySpent < 500) {
                discountLevel = 0;
                
            }


        }

        public override string ToString() {

            return $"Customer ID: {this.id}\n" +
                $" Name: {this.name}\n" +
                $" Address: {this.address}\n" +
                $" Telephone: {this.telephone.TelephoneFormatter()}\n" +
                $" mailing List: {this.mailingList}\n" +
                $" Amount Spent: {this.moneySpent.doubleToCurrency()}\n" +
                $" Discount Level: {this.discountLevel.doubleToPercent()}";
        }
    }
}
