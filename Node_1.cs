using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformedSearchStrategies
{
    class Node_1
    {
        //define state
        public string  State { get; set; }
        //define path cost
        public double  Cost { get; set; }
        //define parent 
        public Node_1 Parent { get; set; }
        //define successor function Fn
        public double  Fn { get; set; }
        //define list of children
        public List<Node_1> Neighbors = new List<Node_1>();
        //costractor to creat state
        public Node_1 (string State)
        {
            this.State = State;
            Parent = null;
        }
        //method to add neighbors for each state
        public void AddNeihbors(Node_1 n,double Cost)
        {
            //add neighbors for each object call this method to list
            this.Neighbors.Add(n);
            n.Cost = Cost;
        }
    }
}
