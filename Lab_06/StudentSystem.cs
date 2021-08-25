using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06
{
    class StudentSystem
    {
        private Dictionary<string, Student> repo;
        public Dictionary<string, Student> Repo
        {
            get{ return repo; }
            private set{repo = value;}
        }
        public StudentSystem() 
        {
            this.Repo = new Dictionary<string,Student>();
        }
        public void parseCommond()
        {
            String[] arg = Console.ReadLine().Split();
            if(arg[0] == "create")
            {
                string name = arg[1];
                int age = int.Parse(arg[2]);
                double grade = double.Parse(arg[3]);
                if (!repo.ContainsKey(name))
                {
                    var student = new Student(name, age, grade);
                    Repo[name] = student;
                }
            }
            else if (arg[0] == "show")
            {
                var name = arg[1];
                if (repo.ContainsKey(name))
                {
                    var student = Repo[name];
                    string view = $"{student.Name} is {student.Age} " +
                        $"year old and grade is {student.Grade}";
                    Console.WriteLine(view);
                }
            }
            else if (arg[0] == "exit")
            {
                Environment.Exit(0);
            }
        }

    }
}
