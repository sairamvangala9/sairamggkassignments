// using System;
// namespace Dijkstra
// {
//     class DijkstrasShortestPath
//     {
//         private static int NO_PARENT = -1;
//         private static int MAX_VALUE = 99999;
//         public void dijkstraPath(int[][] adjacencyMatrix, int startVertex, int endVertex)
//         {
//             int nVertices = adjacencyMatrix[0].Length;
//             int[] shortestDistances = new int[nVertices];
//             bool[] added = new bool[nVertices];
//             for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)
//             {
//                 shortestDistances[vertexIndex] = MAX_VALUE;
//                 added[vertexIndex] = false;
//             }
//             shortestDistances[startVertex] = 0;
//             int[] parents = new int[nVertices];
//             parents[startVertex] = NO_PARENT;
//             for (int i = 1; i < nVertices; i++)
//             {
//                 int nearestVertex = -1;
//                 int shortestDistance = MAX_VALUE;
//                 for (int vertexIndex = 0;vertexIndex < nVertices;vertexIndex++)
//                 {
//                     if (!added[vertexIndex] &&shortestDistances[vertexIndex] <shortestDistance)
//                     {
//                         nearestVertex = vertexIndex;
//                         shortestDistance = shortestDistances[vertexIndex];
//                     }
//                 }
//                 added[nearestVertex] = true;
//                 for (int vertexIndex = 0;vertexIndex < nVertices;vertexIndex++)
//                 {
//                     int edgeDistance = adjacencyMatrix[nearestVertex][vertexIndex];

//                     if (edgeDistance > 0&& ((shortestDistance + edgeDistance) <shortestDistances[vertexIndex]))
//                     {
//                         parents[vertexIndex] = nearestVertex;
//                         shortestDistances[vertexIndex] = shortestDistance +edgeDistance;
//                     }
//                 }
//             }
//             printSolution(startVertex, shortestDistances, parents, endVertex);
//         }
//         private void printSolution(int startVertex,int[] distances,int[] parents,int endVertex)
//         {
//             int nVertices = distances.Length;
//             Console.Write("Vertex\t Distance\tPath");
//             for (int vertexIndex = 0;vertexIndex < nVertices;vertexIndex++)
//             {
//                 if (vertexIndex != startVertex)
//                 {
//                     Console.Write("\n" + startVertex + " -> "+vertexIndex + " \t\t "+distances[vertexIndex] + "\t\t");
//                     printPath(vertexIndex, parents);
//                 }
//             }
//         }
//         private void printPath(int currentVertex,int[] parents)
//         {
//             if (currentVertex == NO_PARENT)
//             {
//                 return;
//             }
//             printPath(parents[currentVertex], parents);
//             Console.Write(currentVertex + " ");
//         }
//     }
//     class Program
//     {
//         public static void Main54()
//         {
//             int INF = 999999;
//             int[][] adjacencyMatrix = new int[10][];
//             DijkstrasShortestPath obj = new DijkstrasShortestPath();
//             adjacencyMatrix[0] = new int[10] { 0, 1, 2, INF, INF, INF, INF, INF, INF, INF };
//             adjacencyMatrix[1] = new int[10] { 1, 0, INF, INF, INF, 3, INF, INF, INF, INF };
//             adjacencyMatrix[2] = new int[10] { 2, INF, 0, 1, INF, INF, INF, INF, INF, INF };
//             adjacencyMatrix[3] = new int[10] { INF, INF, 1, 0, 2, INF, 8, INF, INF, INF };
//             adjacencyMatrix[4] = new int[10] { INF, INF, INF, 2, 0, 1, INF, INF, INF, INF };
//             adjacencyMatrix[5] = new int[10] { INF, 3, INF, INF, 1, 0, INF, 4, INF, INF };
//             adjacencyMatrix[6] = new int[10] { INF, INF, INF, 8, INF, INF, 0, 3, 2, INF };
//             adjacencyMatrix[7] = new int[10] { INF, INF, INF, INF, INF, 4, 3, 0, INF, 1 };
//             adjacencyMatrix[8] = new int[10] { INF, INF, INF, INF, INF, INF, 2, INF, 0, 3 };
//             adjacencyMatrix[9] = new int[10] { INF, INF, INF, INF, INF, INF, INF, 1, 3, 0 };
//             obj.dijkstraPath(adjacencyMatrix, 0, 9);
//             Console.ReadLine();
//         }
//     }
// }