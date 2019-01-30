using System; 
namespace Test2
{
    public class FloydWarshallShortestPath 
    { 
        readonly static int INF = 99999, V = 10; 
        private int[,] path=new int[10,10];
        private int[,] graph;
        void floydWarshall(int[,] graph) 
        { 
            this.graph=graph;
            int[,] dist = new int[V, V]; 
            int i, j, k; 
            for (int v = 0; v < V; v++)
            {
                for (int u = 0; u < V; u++)
                {
                    path[v,u] = graph[v,u];

                    if (v == u)
                        path[v,u] = 0;
                    else if (graph[v,u] != INF)
                        path[v,u] = v;
                    else
                        path[v,u] = -1;
                }
            }
            for (i = 0; i < V; i++) { 
                for (j = 0; j < V; j++) { 
                    dist[i, j] = graph[i, j]; 
                    
                } 
            } 
            for (k = 0; k < V; k++) 
            { 
                for (i = 0; i < V; i++) 
                { 
                    for (j = 0; j < V; j++) 
                    { 
                        if (dist[i, k] + dist[k, j] < dist[i, j])  
                        { 
                            dist[i, j] = dist[i, k] + dist[k, j]; 
                            path[i,j] = path[k,j];
                        } 
                    } 
                } 
            } 
        } 
        private void printSolution(int source,int destination)
        {
            source--;
            destination--;
            Console.Write("Shortest Path from vertex " + (source+1) +" to vertex " + (destination+1) + " is (" + (source+1) + " ");
            printPath(path, source, destination);
            Console.WriteLine((destination+1) + ")");
        }
        private static void printPath(int[,] path, int initial, int final)
        {
            if (path[initial,final] == initial)
            {    
                return;
            }
            printPath(path, initial, path[initial,final]);
            Console.Write((path[initial,final]+1) + " ");
        }
        public static void Main(string[] args) 
        { 
            int[,] graph = { 
                            {0,1,2,INF,INF,INF,INF,INF,INF,INF},
                            {1,0,INF,INF,INF,3,INF,INF,INF,INF},
                            {2,INF,0,1,INF,INF,INF,INF,INF,INF},
                            {INF,INF,1,0,2,INF,8,INF,INF,INF},
                            {INF,INF,INF,2,0,1,INF,INF,INF,INF},
                            {INF,3,INF,INF,1,0,INF,4,INF,INF},
                            {INF,INF,INF,8,INF,INF,0,3,2,INF},
                            {INF,INF,INF,INF,INF,4,3,0,INF,1},
                            {INF,INF,INF,INF,INF,INF,2,INF,0,3},
                            {INF,INF,INF,INF,INF,INF,INF,1,3,0}
                            }; 
            Console.Write("Enter source: ");
            int source=Int32.Parse(Console.ReadLine());
            Console.Write("Enter destination: ");
            int destination=Int32.Parse(Console.ReadLine());
            if((0<=source&&source<=10)&&(0<=destination&&destination<=10))
            {
                FloydWarshallShortestPath a = new FloydWarshallShortestPath(); 
                a.floydWarshall(graph); 
                a.printSolution(source,destination);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter valid Source and Destination values..");
                Console.ReadLine();
            }
        } 
    } 
}