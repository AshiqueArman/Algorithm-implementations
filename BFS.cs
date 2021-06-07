// BFS

using System;
using System.Collections.Generic;

class Graph{

    public int vertices;
    public List<int>[] adj;
    
    // Constructor
    public Graph(int v){
        // Number of nodes
        vertices = v;   
        // Creating a list of nodes according to the number of vertices
        adj = new List<int>[v];
        // Instantiating the nodes
        for(int i=0; i<v; i++){
            adj[i] = new List<int>();
        }

    }

    // Inputing the nodes and the nodes adjacent to them
    // Basically creating the graph
    public void addEdge(int v, int w){
        // 'v' is the node and 'w' is the adjacent node of 'v'
        adj[v].Add(w);
    }

    public void BFS(int s){
        // Creating an array for checking if the nodes have beeen visited or not 
        bool[] visited = new bool[vertices];

        // Creating a queue for BFS
        Queue<int> q = new Queue<int>();

        visited[s] = true;  // source is marked visited
        q.Enqueue(s);   // pushing the visited node to the queue

        // will run until theall the connected nodes have visited
        while( q.Count != 0 ){
            // Dequeue and save the popped node to s
            s = q.Dequeue();
            // Printing the popped node
            Console.WriteLine("Next ---> " + s);
            
            // Checking all the unvisited adjacent nodes and adding them to the queue
            foreach(int next in adj[s]){
                if(!visited[next]){
                    visited[next] = true;
                    q.Enqueue(next);
                }
            }
        }



    }

    static void Main(string[] args){

        Graph graph = new Graph(8);
        
        graph.addEdge(1, 0);
        graph.addEdge(1, 2);
        graph.addEdge(0, 4);
        graph.addEdge(2, 6);
        graph.addEdge(2, 5);
        graph.addEdge(5, 3);
        graph.addEdge(5, 7);
        graph.addEdge(4, 6);
        
        graph.BFS(1);

    }



}
