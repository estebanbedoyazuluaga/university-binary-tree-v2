using System;
namespace BinaryTreeUniversity{
    class UniversityTree{
        public PositionNode Root;

        public void CreatePosition(PositionNode parent, 
                                    Position positionToCreate, 
                                    string parentPositionName){
            

            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;
            if (Root == null){
                Root = newNode;
                return;
            }
            if (parent == null){
                return;
            }
            if (parent.Position.Name == parentPositionName){
                if (parent.left == null){
                    parent.left = newNode;
                    return;
                }
                parent.right = newNode;
                return;
            }
            CreatePosition(parent.left, positionToCreate, parentPositionName);
            CreatePosition(parent.right, positionToCreate, parentPositionName);
        }

        public void PrintTree(PositionNode from){
            if (from == null){
                return;
            }
            Console.WriteLine($"{from.Position.Name} : {from.Position.Salary}");
            PrintTree(from.left);
            PrintTree(from.right);
        }

        public float AddSalaries(PositionNode from){
            if(from == null){
                return 0;
            }
            return from.Position.Salary + AddSalaries(from.left) + AddSalaries(from.right);
        }
        
        //===============================================================================

        public int CountNodes(PositionNode from){
            if(from == null){
                return 0;
            }
            return 1 + CountNodes(from.left) + CountNodes(from.right);
        }

        public float GetAverage(PositionNode from){
            return AddSalaries(from) / CountNodes(from);
        }
        public float GetTotalInTaxes(PositionNode from){
            if(from == null){
                return 0;
            }
            return (from.Position.Salary * from.Position.Tax) + GetTotalInTaxes(from.left) + GetTotalInTaxes(from.right);
        }

        //returns the greatest between 2 floats
        public float GreatestBetweenTwo(float a, float b){
            if (a >= b){
                return a;
            } else {
                return b;
            }
        }
        
        public float GetGreatestSalary(){
            return GetGreatestSalary(Root, 0);
        }

        public float GetGreatestSalaryNoRoot(){
            return  GreatestBetweenTwo(GetGreatestSalary(Root.left, 0), 
                                        GetGreatestSalary(Root.right, 0)
                    );
        }

        public float GetGreatestSalary(PositionNode from, float greatest){

            if (from.left == null){
                return from.Position.Salary;
            } else {
                greatest = GreatestBetweenTwo(from.left.Position.Salary, greatest);
            }

            if (from.right == null){
                return from.Position.Salary;
            } else {
                greatest = GreatestBetweenTwo(from.right.Position.Salary, greatest);
            }

            return GreatestBetweenTwo(from.Position.Salary, greatest);
        }

        public PositionNode GetPositionNode(PositionNode from, string name){
            if (from == null){
                return null;
            } else {
                if (from.Position.Name == name){
                    return from;
                } else {
                    PositionNode deeper_node = GetPositionNode(from.left, name);
                    if (deeper_node == null){
                        deeper_node = GetPositionNode(from.right, name);
                    }
                    return deeper_node;
                }
            }
        }
    }
}
