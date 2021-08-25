using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06
{
    class Student
    {
        private string name;
        private int age;
        private double grade;
        public Student() { }
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string name,int age,double grade) 
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
        public string Name { get; set; }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public int Age { get; set; }


    }
}
