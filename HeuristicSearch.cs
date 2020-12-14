using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformedSearchStrategies
{
    //implement informed search algorithms
    class HeuristicSearch
    {
        //Greedy search algorithm
        public void Greedy(Node_1 Start,Node_1 Goal,Hashtable h)
        {
            //creat empty PriorityQueue
            PriorityQueue G_Pq = new PriorityQueue();
            //insert start point to PriorityQueue
            G_Pq.Enqueue(Start);
            //list of visited nodes 
            List<Node_1> RepeatedStates = new List<Node_1>();
            //loop on graph
            while (G_Pq.Count != 0)
            {
                //remove first point in the PriorityQueue
                Node_1 Current =(Node_1 ) G_Pq.Dequeue();
                //display visited nodes
                Console.WriteLine(Current.State + "\t visited");
                //add visited nodes in list
                RepeatedStates.Add(Current);
                //check goal
                if (Current.State == Goal.State)
                {
                    //return goal
                    //list to get parent or path
                    List<string> SolutionGoal = new List<string>();
                    //tn insert parent or path in list
                    while (Current != null)
                    {
                        SolutionGoal.Insert(0, Current.State);
                        Current = Current.Parent;
                    }
                    //display parent or path
                    Console.WriteLine("Goal");
                    foreach (var item in SolutionGoal)
                    {
                        Console.WriteLine(item);
                    }
                    //To stop loop
                    break;
                }
                //add neighbors for removed point
                else
                {
                    foreach (var item in Current.Neighbors)
                    {
                        //check on visited node from list to Prevents repate
                        if (RepeatedStates.Contains(item))
                        {
                            continue;
                        }
                        //get h(n) from hashtable to calc f(n)
                        item.Fn = (double)h[item];
                        //insert itenm in PriorityQueue
                        G_Pq.Enqueue(item);
                    }
                }
            }
        }
        //A* search algorithm
        public void Astar(Node_1 Start, Node_1 Goal, Hashtable h)
        {
            //creat empty PriorityQueue
            PriorityQueue Astar_Pq = new PriorityQueue();
            //insert start point to PriorityQueue
            Astar_Pq.Enqueue(Start);
            //list of visited nodes 
            List<Node_1> RepeatedStates = new List<Node_1>();
            //loop on graph
            while (Astar_Pq.Count != 0)
            {
                //remove first point in the PriorityQueue
                Node_1 Current = (Node_1)Astar_Pq.Dequeue();
                //display visited nodes
                Console.WriteLine(Current.State + "\t visited");
                //add visited nodes in list
                RepeatedStates.Add(Current);
                //check goal
                if (Current.State == Goal.State)
                {
                    //return goal
                    //list to get parent or path
                    List<string> SolutionGoal = new List<string>();
                    //tn insert parent or path in list
                    while (Current != null)
                    {
                        SolutionGoal.Insert(0, Current.State);
                        Current = Current.Parent;
                    }
                    //display parent or path
                    Console.WriteLine("Goal");
                    foreach (var item in SolutionGoal)
                    {
                        Console.WriteLine(item);
                    }
                    //To stop loop
                    break;
                }
                //add neighbors for removed point
                else
                {
                    foreach (var item in Current.Neighbors)
                    {
                        //check on visited node from list to Prevents repate
                        if (RepeatedStates.Contains(item))
                        {
                            continue;
                        }
                        //get g(n) from hashtable to calc f(n)
                        item.Cost += Current.Cost;
                        //get h(n) from hashtable and calc f(n)
                        item.Fn = item.Cost +(double)h[item];
                        //insert itenm in PriorityQueue
                        Astar_Pq.Enqueue(item);
                    }
                }
            }
        }
        //Uniform Cost Search algorithm (uninformed search strategy)
        public void UCS(Node_1 Start, Node_1 Goal, Hashtable h)
        {
            //creat empty PriorityQueue
            PriorityQueue UCS_Pq = new PriorityQueue();
            //insert start point to PriorityQueue
            UCS_Pq.Enqueue(Start);
            //list of visited nodes 
            List<Node_1> RepeatedStates = new List<Node_1>();
            //loop on graph
            while (UCS_Pq.Count != 0)
            {
                //remove first point in the PriorityQueue
                Node_1 Current = (Node_1)UCS_Pq.Dequeue();
                //display visited nodes
                Console.WriteLine(Current.State + "\t visited");
                //add visited nodes in list
                RepeatedStates.Add(Current);
                //check goal
                if (Current.State == Goal.State)
                {
                    //return goal
                    //list to get parent or path
                    List<string> SolutionGoal = new List<string>();
                    //tn insert parent or path in list
                    while (Current != null)
                    {
                        SolutionGoal.Insert(0, Current.State);
                        Current = Current.Parent;
                    }
                    //display parent or path
                    Console.WriteLine("Goal");
                    foreach (var item in SolutionGoal)
                    {
                        Console.WriteLine(item);
                    }
                    //To stop loop
                    break;
                }
                //add neighbors for removed point
                else
                {
                    foreach (var item in Current.Neighbors)
                    {
                        //check on visited node from list to Prevents repate
                        if (RepeatedStates.Contains(item))
                        {
                            continue;
                        }
                        //get g(n) from hashtable to calc f(n)
                        item.Cost += Current.Cost;
                        //get h(n) from hashtable and calc f(n)
                        item.Fn = item.Cost;
                        //insert itenm in PriorityQueue
                        UCS_Pq.Enqueue(item);
                    }
                }
            }
        }
    }
}
