using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShortestPath
{
    class ShortestPath
    {
        private int m_Vertices=14;
        private int m_Edges;
        private int[] m_Distance;
        private int[,] m_Graph;
        private string[] m_Path;
        private bool[] m_Visit;
        public ShortestPath()
        {
            m_Graph = new int[,]{{0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                                 {0,0,1,2,0,0,0,0,0,0,0,0,0,0,},
                                 {0,1,0,0,0,3,0,0,0,0,0,0,0,0,},
                                 {0,2,0,0,1,0,0,0,0,0,0,0,0,0,},
                                 {0,0,0,1,0,0,2,0,0,0,0,0,8,0,},
                                 {0,0,3,0,0,0,1,0,0,4,0,0,0,0,},
                                 {0,0,0,0,2,1,0,0,0,0,0,0,0,0,},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                                 {0,0,0,0,0,4,0,0,0,0,1,0,3,0,},
                                 {0,0,0,0,0,0,0,0,0,1,0,0,0,3,},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                                 {0,0,0,0,8,0,0,0,0,3,0,0,0,2,},
                                 {0,0,0,0,0,0,0,0,0,0,3,0,2,0,}
                                 };
            this.DisplayAdjacentMatrix();
            this.ShortPathFinder(1, 13);
            Console.Write("\nSource: {0} , Destinantion: {1} , Distance from Source: {2} and path: {3}\n", 1, 13, m_Distance[13], m_Path[13] + "\n");
        }
        /// <summary>
        /// Prints the adjacent matrix of the graph
        /// </summary>
        private void DisplayAdjacentMatrix()
        {
            Console.WriteLine("The Adjacent Matrix Representation of the given graph is:\n");
            for (int temp1 = 0; temp1 < m_Vertices; temp1++)
            {
                for (int temp2 = 0; temp2 < m_Vertices; temp2++)
                {
                    Console.Write(m_Graph[temp1, temp2] + " ");
                }
                Console.WriteLine("");
            }
        }
        /// <summary>
        /// checks the minimum distance from the vertex
        /// </summary>
        /// <returns>index of the minimum distance</returns>
        private int MinimumDistanceCaluclator()
        {
            int minimum = int.MaxValue, minimumIndex = -1;

            for (int temp = 0; temp < m_Vertices; temp++)
            {
                if (m_Visit[temp] == false && m_Distance[temp] < minimum)
                {
                    minimum = m_Distance[temp];
                    minimumIndex = temp;
                }
            }
            if (minimumIndex == -1)
            {
                minimumIndex = 0;
            }
            return minimumIndex;
        }
        /// <summary>
        /// finds the shortest path from source to destination and stores into m_distance array
        /// </summary>
        /// <param name="source">start</param>
        /// <param name="destination">finish</param>
        private void ShortPathFinder(int source=1, int destination=13)
        {
            m_Distance = new int[m_Vertices];
            m_Path = new string[m_Vertices];
            m_Visit = new bool[m_Vertices];
            for (int temp = 0; temp < m_Vertices; temp++)
            {
                m_Distance[temp] = int.MaxValue;
                m_Visit[temp] = false;
            }
            m_Distance[source] = 0;
            for (int count = 0; count <= m_Vertices - 1; count++)
            {
                int minimumIndex = MinimumDistanceCaluclator();
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
