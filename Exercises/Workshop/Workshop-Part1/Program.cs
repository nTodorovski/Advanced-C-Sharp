using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_Part1.Classes;


namespace Workshop_Part1 {
    class Program {
        static void Main(string[] args) {
            Logger.ArchiveLog();
            TechnicalStuff technician1 = new TechnicalStuff {
                ID = 1,
                Name = "Branko",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-25),
                Title = "Hardware specialist",
                Email = "branko@gmail.com",
                Salary = 1800
            };
            technician1.MaintainSystems();

            Accountant accountant = new Accountant {
                ID = 2,
                Name = "Petar",
                Surname = "Petrov",
                BirthDate = DateTime.Now.AddYears(-25),
                Title = "Accountant",
                Email = "petar@gmail.com",
                Salary = 2600

            };
            accountant.MaintainAccounts();

            Robot robot = new Robot {
                ID = 3,
                Name = "Robo",
                Surname = "Robo",
                BirthDate = DateTime.Now.AddYears(-5),
                Title = "Robot",
                Email = "robot@gmail.com",
                Salary = 0
            };
            robot.MaintainDatawareHouse();

            Manager manager = new Manager {
                ID = 4,
                Name = "Aleksandar",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-46),
                Title = "Manager",
                Email = "aleksandar@gmail.com",
                Salary = 4000
            };
            manager.DoEmployeeApprisal(technician1);
            manager.PromoteEmployee(accountant);
            manager.SendCommunication();
            manager.PromoteSubEmployees(455);
            manager.AddSubEmployee(technician1);
            manager.AddSubEmployee(accountant);
            Console.WriteLine("----------------------------------------------");
            foreach (Employee employee in manager.GetEmployees())
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine(manager.ToString());

            manager.PromoteSubEmployees(455);
            foreach (Employee employee in manager.GetEmployees())
            {
                Console.WriteLine(employee.ToString());
            }
            Director director = new Director {
                ID = 5,
                Name = "Violeta",
                Surname = "Micova",
                BirthDate = DateTime.Now.AddYears(-55),
                Title = "Director",
                Email = "violeta@gmail.com",
                Salary = 6400
            };
            Console.WriteLine();
            director.PromoteEmployee(manager);
            director.AddSubEmployee(robot);
            Console.WriteLine("----------------------------------------------");
            foreach (Employee employee in director.GetEmployees())
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine(director.ToString());
            
            Console.ReadLine();
        }
    }
}
