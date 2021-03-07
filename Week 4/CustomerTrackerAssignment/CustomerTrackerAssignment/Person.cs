using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTrackerAssignment {
    class Person {
        public string name {
            get;
            set;
        }

        public string address {
            get;
            set;
        }

        public string telephone {
            get;
            set;
        }

        public Person(string name, string address, string telephone) {
            this.name = name;
            this.address = address;
            this.telephone = telephone;
        }


        public override string ToString() {
            return $"Name: {this.name}\n Address: {this.address}\n, Telephone: {this.telephone}";
        }



    }
}
