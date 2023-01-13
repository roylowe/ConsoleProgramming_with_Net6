using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        public string FirstName { get; set; }  //access modifier data type variable name accessors(get or set)
        public string LastName { get; set; }  //standard properties in a class begin with capital letter
       
        public int Age { get; set; }

        //Fileds are private  start with lowercase
        private double _salary { get; set; }

        //define a method to set the salary
        public void setSalary(double salary)
        {
            _salary = salary;
        }

        //define a  method to return what a salary is
        public double getSalary()
        {
            return _salary;
        }

        // method to get the full name and return it
        public string getFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string getFullName(String middleName)
        {
            return $"{FirstName} {middleName} {LastName}";
        }
    }
}

