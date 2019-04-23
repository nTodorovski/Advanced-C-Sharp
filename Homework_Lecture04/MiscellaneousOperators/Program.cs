﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscellaneousOperators {
    class Program {

        enum weekDays { Mon, Tue, Wed, Thu, Fri, Sat, Sun};
        struct Coordinates { int x; int y; }
        public class Student {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class SEDCStudent : Student {
            public bool IsAdvanced { get; set; } = true;
        }

        static void Main(string[] args) {

            #region Operator default 
            /*
            //default values for value types:
            Console.WriteLine("int {0}",default(int));
            Console.WriteLine("DateTime {0}",default(DateTime));
            Console.WriteLine("Char {0}",default(char));
            Console.WriteLine("Guid {0}",default(Guid));
            Console.WriteLine("Enum {0}",default(weekDays));       //Enum
            Console.WriteLine("Struct {0}",default(Coordinates));    //new Struct()

            Console.WriteLine("-----------------");
            // null defaults:
            Console.WriteLine("Class {0}",default(Student));         
            Console.WriteLine("object {0}",default(object));
            Console.WriteLine("string {0}",default(string));
            Console.WriteLine("Interface {0}",default(IDisposable));
            Console.WriteLine("Dynamic {0}",default(dynamic));
             */
            #endregion

            #region Operator sizeof
            /*
            Console.WriteLine();
            Console.WriteLine("bool {0}", sizeof(bool));   // Returns 1.
            Console.WriteLine("byte {0}", sizeof(byte));  // Returns 1.
            Console.WriteLine("sbyte {0}", sizeof(sbyte));   // Returns 1.
            Console.WriteLine("char {0}", sizeof(char));  // Returns 2.
            Console.WriteLine("short {0}", sizeof(short));  // Returns 2.
            Console.WriteLine("ushort {0}", sizeof(ushort));   // Returns 2.
            Console.WriteLine("int {0}", sizeof(int));   // Returns 4.
            Console.WriteLine("uint {0}", sizeof(uint));  // Returns 4.
            Console.WriteLine("float {0}", sizeof(float));   // Returns 4.
            Console.WriteLine("long {0}", sizeof(long));     // Returns 8.
            Console.WriteLine("ulong {0}", sizeof(ulong));    // Returns 8.
            Console.WriteLine("double {0}", sizeof(double));   // Returns 8.
            Console.WriteLine("decimal {0}", sizeof(decimal));  // Returns 16.
            */
            #endregion

            #region Operator typeof
            /*
            Type type;
            type = typeof(Student); Console.WriteLine(type);
            type = typeof(IDisposable); Console.WriteLine(type);
            type = typeof(List<>); Console.WriteLine(type);
            type = typeof(Dictionary<int,string>); Console.WriteLine(type);
            type = typeof(int); Console.WriteLine(type);

            Student s = new Student();
            SEDCStudent sEDCStudent = new SEDCStudent();
            Console.WriteLine(s.GetType() == typeof(Student));
            Console.WriteLine(sEDCStudent.GetType() == typeof(SEDCStudent));
            Console.WriteLine(sEDCStudent.GetType() == typeof(Student));
            Console.WriteLine(s.GetType() == typeof(SEDCStudent));
            */
            #endregion

            Student s = new Student();
            SEDCStudent sEDCStudent = new SEDCStudent();

            #region Operator nameof

            int @int = 10;
            Console.WriteLine("The name of the vaiable @int is {0}", nameof(@int));
            Console.WriteLine(nameof(sEDCStudent));
            
            #endregion


            #region "Exclusive OR" operator
            /*
            true ^ false // Returns true
            false ^ true // Returns true
            false ^ false // Returns false
            true ^ true // Returns false
            */
            #endregion

            #region "Null-coalesce" operator
            
            SEDCStudent SedcStud = new SEDCStudent(); 
            SEDCStudent student = null;
            var NewStudent = student ?? SedcStud; 
            Console.WriteLine("New is advanced? {0}",NewStudent.IsAdvanced);
            
            #endregion

            #region Bit-Shifting operators
            /*
            //Left-Shift
            uint num = 15;
            Console.WriteLine(num);
            uint numX2 = num << 1;
            Console.WriteLine(numX2);
            uint shiftFour = num << 4;
            Console.WriteLine(shiftFour);

            //Right-Shift
            uint broj = 240;
            Console.WriteLine(broj);
            uint half = broj >> 1;
            Console.WriteLine(half);
            uint rightShiftFour = broj >> 4;
            Console.WriteLine(rightShiftFour);
            */
            #endregion


        }
    }
}
