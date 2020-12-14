using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformedSearchStrategies
{
    class Program
    {
        static void Main(string[] args)
        {
            //object to initialize start point
            Node_1 Start = new Node_1("S");
            //object to initialize goal point
            Node_1 Goal = new Node_1("G");
            //group of objects to creat graph 
            Node_1 a = new Node_1("a");
            Node_1 b = new Node_1("b");
            Node_1 c = new Node_1("c");
            Node_1 d = new Node_1("d");
            Node_1 e = new Node_1("e");
            //

            //add neihbors for each node
            Start.AddNeihbors(a, 1.5);
            Start.AddNeihbors(d, 2);
            a.AddNeihbors(b, 2);
            b.AddNeihbors(c, 3);
            c.AddNeihbors(Goal, 4);
            d.AddNeihbors(e, 3);
            e.AddNeihbors(Goal, 2);
            //

            //object of hashtable
            Hashtable H = new Hashtable
            //object add node and cost to calc f(n)
            {
                { (Node_1)a, (double)4 },
                { (Node_1)b, (double)2 },
                { (Node_1)c, (double)4 },
                { (Node_1)d, (double)4.5 },
                { (Node_1)e, (double)2 },
                { (Node_1)Goal, (double)0 },
                { (Node_1)Start, (double)0 }
            };
            //

            //object from hueristic search algorithm
            HeuristicSearch hs = new HeuristicSearch();
            //object use greedy algorithm
            //hs.Greedy(Start, Goal, H);
            //object use A* algorithm
            //hs.Astar(Start, Goal, H);
            //object use Uniform Cost Search algorithm (uninformed search strategy)
            hs.UCS(Start, Goal, H);

            Console.ReadKey();
        }
    }
}
