using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string route = "";
            int distance = 0;

            Console.WriteLine("Enter starting point: ");
            string startLoc = Console.ReadLine();
            Console.WriteLine("Enter destination: ");
            string endLoc = Console.ReadLine();
 
            if (startLoc == "B" && endLoc == "H"){
                route = "B - D - G - H";
                distance = 10;
            }

            // Driver Code 
            int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            GFG t = new GFG();
            t.dijkstra(graph, 0);

        
            Console.WriteLine("The shortest route to take starting at " + startLoc + " and ending at " + endLoc + " is: " + route);
            Console.WriteLine("The distance of this route is: " + distance);

            

            // B - D = 4

            // B - E = 7

            // C - D = 1

            // C - F = 4

            // D - F = 1

            // D - G = 2

            // E - H = 10

            // F - G = 3

            // G - H = 4


        }
    }
}
