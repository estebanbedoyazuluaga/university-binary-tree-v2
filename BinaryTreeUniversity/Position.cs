using System;

namespace BinaryTreeUniversity{
    class Position{
        public String Name;
        public float Salary;
        public float tax;

        public Position(String Name, float Salary){
            this.Name = Name;
            this.Salary = Salary;
            this.tax = 0;
        }

        public Position(String Name, float Salary, float Tax){
            this.Name = Name;
            this.Salary = Salary;
            this.tax = Tax;
        }
    }
}
