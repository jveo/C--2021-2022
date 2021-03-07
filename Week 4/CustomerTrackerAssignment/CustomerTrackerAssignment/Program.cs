using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTrackerAssignment {

    class Program {

        static void Main(string[] args) {

            int count = 1;
            int index = 0;
            int id = 1;

            PreferredCustomer[] customerArr = new PreferredCustomer[3];

            while (count <= 3 ) {

                Console.WriteLine("Enter the customer's name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the customer's address");
                string address = Console.ReadLine();

                Console.WriteLine("Enter the customer's telephone number");
                string telephone = Console.ReadLine();
  
                Console.WriteLine("Would you like to sign up for the mailing list? (Y, N) ");
                bool mailingList = Console.ReadLine() == "Y" ? true : false;

                
                

                customerArr[index] = new PreferredCustomer(name, address, telephone, id, mailingList);

                
                count++;
                id++;
                index++;
            }



            foreach (PreferredCustomer i in customerArr) {
                
                Console.WriteLine(i);
            }

          


            Console.ReadLine();
        }

    }
}
