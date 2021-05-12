using System;

namespace BinaryTreeUniversity{
    class Position{
        public String Name;
        public float Salary;
        public float Tax;

        public Position(String Name, float Salary){
            this.Name = Name;
            this.Salary = Salary;
            this.Tax = 0;
        }

        public Position(String Name, float Salary, float Tax){
            this.Name = Name;
            this.Salary = Salary;
            this.Tax = Tax;
        }
    }
}
