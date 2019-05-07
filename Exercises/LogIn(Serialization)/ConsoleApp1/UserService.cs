using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UserService
    {
        public void Register()
        {
            string directoryPath = @"C:\Users\todor\Desktop\Advanced-C-Sharp\Exercises\LogIn(Serialization)\ConsoleApp1\papka";
            Console.WriteLine("Enter ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Role: (Student,Trainer,Admin)");
            string input = Console.ReadLine();
            Role role = Role.Student;
            if (input == Role.Trainer.ToString())
            {
                role = Role.Trainer;
            }
            else if (input == Role.Admin.ToString())
            {
                role = Role.Admin;
            }

            User user = new User()
            {
                ID = id,
                Username = username,
                Password = password,
                Age = age,
                Role = role
            };

            string result = string.Empty;
            if(File.Exists(directoryPath + @"\database.json"))
            {
                using (StreamReader sr = new StreamReader(directoryPath + @"\database.json"))
                {
                    result = sr.ReadToEnd();
                }
            }

            if(result.Length == 0)
            {
                using (StreamWriter sw = new StreamWriter(directoryPath + @"\database.json"))
                {
                    sw.WriteLine(JsonConvert.SerializeObject(new List<User>() { user }));
                }
            }
            else
            {
                List<User> users = new List<User>();
                users = JsonConvert.DeserializeObject<List<User>>(result);
                users.Add(user);
                using (StreamWriter sw = new StreamWriter(directoryPath + @"\database.json"))
                {
                    sw.WriteLine(JsonConvert.SerializeObject(users));
                }
            }
        }
        public void LogIn()
        {
            string directoryPath = @"C:\Users\todor\Desktop\Advanced-C-Sharp\Exercises\LogIn(Serialization)\ConsoleApp1\papka";
            string result = String.Empty;
            using (StreamReader sr = new StreamReader(directoryPath + @"\database.json"))
            {
                result = sr.ReadToEnd();
            }
            List<User> users = new List<User>();
            users = JsonConvert.DeserializeObject<List<User>>(result);

            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            LoggerService log = new LoggerService();
            User userChangingPass = new User();
            foreach (var userce in users)
            {
                if(userce.Username == username && userce.Password == password)
                {
                    if(!File.Exists(directoryPath + @"\log.txt"))
                    {
                        File.Create(directoryPath + @"\log.txt").Close()
;
                        log.Log(userce.Username, userce.Password, directoryPath + @"\log.txt");
                    }
                    else
                    {
                        log.Log(userce.Username, userce.Password, directoryPath + @"\log.txt");
                    }

                    int action1;
                    Console.WriteLine($"Welcome {userce.Username}!");
                    Console.WriteLine("Choose Action:");
                    Console.WriteLine("1. Change Password");
                    Console.WriteLine("2. Exit");
                    bool result1 = int.TryParse(Console.ReadLine(), out action1);
                    if (result1)
                    {
                        if(action1 == 1)
                        {
                            userChangingPass = userce;
                        }
                        else if(action1 == 2)
                        {
                            return;
                        }
                    }
                }
            }
            ChangePassword(userChangingPass);
        }

        public void ChangePassword(User user)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Write your new password:");
                string input = Console.ReadLine();
                if (user.Password == input)
                {
                    Console.WriteLine("The password cannot be as the old one! Press any key try again!");
                    Console.ReadLine();
                    continue;
                }
                else if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Password cannot be empty. Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    user.Password = input;
                    Console.WriteLine("Password changed!");
                    break;
                }
            }
        }
    }
}
