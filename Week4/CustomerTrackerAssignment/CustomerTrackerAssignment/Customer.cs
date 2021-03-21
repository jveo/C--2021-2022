using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTrackerAssignment {
    class Customer : Person {

        int id;
        bool mailingList;
     

        public Customer(string name, string address, string telephone, int id, bool mailingList) : 
            base(name, address, telephone) {
            this.id = id;
            this.mailingList = mailingList;
            
        }

        public override string ToString() {
            return $"Customer ID: {this.id}\n" +
                $" Name: {this.name}\n" +
                $" Address: {this.address}\n" +
                $" Telephone: {this.telephone.TelephoneFormatter()}\n" +
                $" mailing List: {this.mailingList}\n";
            //$" Amount Spent: {moneySpent.doubleToCurrency()}\n
            //Discount Level: {discountLevel.doubleToPercent()}";
        }

    }

}
