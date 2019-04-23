﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersSorting {
    class Program {
        static void Main(string[] args) {

            Customer c1 = new Customer("igor", "partizanska 95", "Skopje", 30000);
            Customer c2 = new Customer("dejan", "roza luxemburg 1", "Skopje", 25000);
            Customer c3 = new Customer("ivan", "partizanska 95", "Strumica", 29000);
            Customer c4 = new Customer("petar", "vodjanska 95", "Bitola", 35000);
            Customer c5 = new Customer("marko", "helsinshka", "Veles", 21000);
            Customer c6 = new Customer("marko", "helsinshka", "Veles", 21000);

            Customer[] customers = new Customer[] { c1, c2, c3, c4, c5 };
            Console.WriteLine(c5.Equals(c6)); // TRUE
            Console.WriteLine(c1 == c2); // FALSE
            Console.WriteLine(c5 == c6); // TRUE
            Console.WriteLine(c4 != c5); // TRUE
            Array.Sort(customers, new CustomerMonthlySpendComparer());
            //Array.Sort(customers); //fails because IComparer is not implemented
            Array.Sort(customers);

            foreach (var c in customers) {
                c.PrintCustomer();
            }

            Array.Sort(customers, new CustomerCityComparer());
            foreach (var c in customers) {
                c.PrintCustomer();
            }
             

        }
    }
}
