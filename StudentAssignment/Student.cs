using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssignment
{
    class Student
    {
        public string name;
        public int age;
        const int MIN_AGE = 18;
        const int MAX_AGE = 99;
        public double mark = 0;
        static double sumOfMarks;
        static int nrOfMarks = 0;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < MIN_AGE || value > MAX_AGE) 
                {
                    Console.WriteLine("Invalid age value!");
                }
                else age = value;
            }
        }
        public Student(string name, int age) 
        {
            this.name = name;
            Age = age;
        }
        public string Info
        {
            get
            {
                if (Age < MAX_AGE && age > MIN_AGE)
                {
                    return name + Convert.ToString(Age);
                }
                return name;
            }

        }
        public double Mark
        {
            set
            {
                if (value > 0 && value <= 10)
                {
                    mark = value;
                    sumOfMarks = sumOfMarks + value;
                    nrOfMarks++;
                }
                else if (value > 10 || value < 0)
                    Console.WriteLine("Invalid mark!");
            } 
        } 
        public void averageMarks()
        {
            Console.WriteLine(sumOfMarks/nrOfMarks);
        }
    }
}
