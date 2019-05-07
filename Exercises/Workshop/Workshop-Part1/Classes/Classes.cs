using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Workshop_Part1.Interfaces;

namespace Workshop_Part1.Classes {

    public abstract class Employee {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        // you can implement virtual methods inside abstract class
        public override string ToString() {
            return ID + " " + Name + " " + Surname + " " + Title + " " + BirthDate.ToString("yyyy-mm-dd") + " " + Salary + " " + Email;
        }
    }

    public class TechnicalStuff : Employee, IWorkable, IEatable {
        public void MaintainSystems() {
            Logger.Log("Technician maintains equipement.");           
        }
        public void Work() {
            Logger.Log("Technician Working...");
        }
        public void Eat() {
            Logger.Log("Technician Eating...");
        }
    }

    public class Accountant : Employee, IEatable, IManageable {
        public void MaintainAccounts() {
            Logger.Log("Accountant does general ledger booking.");
        }
        public void Manage() {
            Logger.Log("Accountant managing...");
        }
        public void Eat() {
            Logger.Log("Accountant Eating...");
        }
    }
         
    public class Robot : Employee, IWorkable {
        public void MaintainDatawareHouse() {
            Logger.Log("Robot does risky stuff.");
        }
        public void Work() {
            Logger.Log("Robot Working...");
        }
    }

    public abstract class ManagementStaff : Employee, IManageable {

        public string EmailList
        {
            get
            {
                string result = String.Empty;
                foreach (Employee employee in employees)
                {
                    result += employee.Email + ";";
                }
                return result;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + EmailList;
        }

        public void DoEmployeeApprisal(Employee employee) {
            Logger.Log(employee.Name + " has got an apprisal");
        }
        public void PromoteEmployee(Employee employee) {
            Logger.Log(employee.Name + " has got a promotion");
        }

        public void Manage() {
            Logger.Log("Management Stuff Working...");
        }

        private List<Employee> employees = new List<Employee>();

        public void AddSubEmployee(Employee e)
        {
            employees.Add(e);
        }

        public void RemoveSubEmployee(Employee e)
        {
            employees.Remove(e);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void PromoteSubEmployees(int totalPromotionAmount)
        {
            try
            {
                double numberOfEmployees = employees.Count();
                if (numberOfEmployees == 0)
                {
                    throw new Exception(LogType.Error.ToString());
                }
                else
                {
                    double sumaNaSekoj = (double)totalPromotionAmount / numberOfEmployees;
                    foreach (Employee employee in employees)
                    {
                        employee.Salary += sumaNaSekoj;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // virtual or abstract memebers cannot be private
        public abstract void SendCommunication();
    }

    public class Manager : ManagementStaff {
        public async override void SendCommunication()
        {
            Logger.Log("Message sent from the Manager");
            string poraka = await ProcessCommunication();
            Logger.Log(poraka);
        }

        public static async Task<string> ProcessCommunication()
        {
            await Task.Delay(10000);
            return "async msg finished from Manager";
        }
    }

    public class Director : ManagementStaff {
        public async override void SendCommunication() {
            Logger.Log("Message sent from the Director");
            string poraka = await ProcessCommunication();
            Logger.Log(poraka);
        }
        public static async Task<string> ProcessCommunication()
        {
            await Task.Delay(11000);
            return "async msg finished from Director";
        }
    }


}
