using System;

namespace ShortestPath
{
    class ShortestPath
    {
        private int m_Vertices;
        private int m_Edges;
        private int[] m_Distance;
        private int[,] m_Graph;
        private string[] m_Path;
        private bool[] m_Visit;
        public ShortestPath()
        {
            Console.WriteLine("Enter number of Vertices and Edges of the graph");
            m_Vertices = int.Parse(Console.ReadLine());
            m_Edges = int.Parse(Console.ReadLine());
            m_Graph = new int[m_Vertices, m_Vertices];
            this.SetGraph();
            this.UserControl();
        }
        /// <summary>
        /// used to give control to the user
        /// </summary>
        private void UserControl()
        {
            int option = 0;
            while (option != 2)
            {
                Console.WriteLine("\noptions\n1:to Find min Distance from source and destinantion\n2.Exit...");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("enter source and Destination vertex (start from 0 to {0})", m_Vertices - 1);
                            int source = int.Parse(Console.ReadLine());
                            int destination = int.Parse(Console.ReadLine());
                            this.ShortPathCaluclator(source, destination);
                            printSolution(source, destination);
                            Console.Write("\nPress ENTER to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Press ENTER to Exit...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong Option,please Try again");
                            break;
                        }
                }
            }
        }
        /// <summary>
        /// this method sets the graph in form of adjacent matrix
        /// </summary>
        private void SetGraph()
        {
            int firstVertex, secondVertex,value;
            for(int temp = 0;temp < m_Edges; temp++)
            {
                Console.WriteLine("Enter Source, Destinantion & Weight of Edge {0} :", temp+1);
                firstVertex = int.Parse(Console.ReadLine());
                secondVertex = int.Parse(Console.ReadLine());
                value = int.Parse(Console.ReadLine());
                if (value < m_Graph[firstVertex, secondVertex] || m_Graph[firstVertex, secondVertex]==0)
                {
                    m_Graph[firstVertex, secondVertex] = value;
                    m_Graph[secondVertex, firstVertex] = m_Graph[firstVertex, secondVertex];
                }
            }
            Console.WriteLine("The Adjacent Matrix Representation of your graph is:\n");
            for(int tempOne=0;tempOne < m_Vertices; tempOne++)
            {
                for(int tempTwo=0;tempTwo< m_Vertices; tempTwo++)
                {
                    Console.Write(m_Graph[tempOne,tempTwo]+" ");
                }
                Console.WriteLine("");
            }
        }
        /// <summary>
        /// checks the minimum distance from the vertex
        /// </summary>
        /// <returns>index of the minimum distance</returns>
        private int ShortestDistanceCaluclator()
        { 
            int minimum = int.MaxValue, minimumIndex = -1;
            //checking node connection with other nodes
            for (int temp = 0; temp < m_Vertices; temp++)
            {
                if (m_Visit[temp] == false && m_Distance[temp] < minimum)
                {
                    minimum = m_Distance[temp];
                    minimumIndex = temp;
                }
            }
            if(minimumIndex == -1)
            {
                minimumIndex = 0;
            }
            return minimumIndex;
        } 
        /// <summary>
        /// used to print the details
        /// </summary>
        /// <param name="source">start point</param>
        /// <param name="destination">Destination point</param>
        private void printSolution(int source, int destination)
        {
            Console.Write("Source: {0} ,Destinantion: {1} ,Distance from Source: {2} and path: {3}\n",source,destination, m_Distance[destination], m_Path[destination] + "\n");
        }
        private void ShortPathCaluclator(int source, int destination)
        {
            m_Distance = new int[m_Vertices];
            m_Path = new string[m_Vertices];
            m_Visit = new bool[m_Vertices];
            //initalixing the m_Distance to infinity and m_Visit to false
            for (int temp = 0; temp < m_Vertices; temp++)
            {
                m_Distance[temp] = int.MaxValue;
                m_Visit[temp] = false;
            }
            m_Distance[source] = 0;
            //checking each vertex from start point to end point
            for (int count = 0; count <= m_Vertices - 1; count++)
            {
                int minimumIndex = ShortestDistanceCaluclator();
                m_Visit[minimumIndex] = true;
                for (int temp = 0; temp < m_Vertices; temp++)
                {
                    if ((!m_Visit[temp]) && (m_Graph[minimumIndex, temp] != 0) && (m_Distance[minimumIndex] != int.MaxValue) && (m_Distance[minimumIndex] + m_Graph[minimumIndex, temp] < m_Distance[temp]))
                    {
                        m_Distance[temp] = m_Distance[minimumIndex] + m_Graph[minimumIndex, temp];
                        m_Path[temp] = (minimumIndex == source) ? (minimumIndex.ToString()) : (m_Path[minimumIndex] + "->" + (minimumIndex));
                    }
                }
                m_Path[count] = m_Path[destination] + "->" + (destination);
            }
        }
    }
}
