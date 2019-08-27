using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private Node Root=null;
        public BinarySearchTree()
        {
            this.InsertNode(7);
            this.InsertNode(3);
            this.InsertNode(5);
            this.InsertNode(1);
            this.InsertNode(4);
            this.InsertNode(6);
            this.InsertNode(11);
            this.InsertNode(9);
            this.InsertNode(8);
            this.InsertNode(13);
            this.InsertNode(14);
            this.InsertNode(12);
            Console.Write("\nascending order traversal : ");
            this.GetAscendingOrder(this.GetRootNode());
            Console.Write("\ndescending order traversal : ");
            this.GetDescendingOrder(this.GetRootNode());
            Console.WriteLine("\nenter element to search in tree");
            double element = double.Parse(Console.ReadLine());
            this.SearchNode(this.GetRootNode(), element);
        }
        /// <summary>
        /// to store the root node position
        /// </summary>
        /// <returns>root node</returns>
        private Node GetRootNode()
        {
            return Root;
        }
        
        /// <summary>
        /// inserts the node in the binary search tree
        /// </summary>
        /// <param name="value">value of node</param>
        private void InsertNode(double value)
        {
            Node newNode = new Node();
            newNode.m_Value = value;
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Node currentNode = Root;
                Node parentNode;
                while (true)
                {
                    parentNode = currentNode;
                    if (value < currentNode.m_Value)
                    {
                        currentNode = currentNode.m_Left;
                        if (currentNode == null)
                        {
                            parentNode.m_Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.m_Right;
                        if (currentNode == null)
                        {
                            parentNode.m_Right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// printing the nodes in asending order 
        /// </summary>
        /// <param name="root">root node</param>
        private void GetAscendingOrder(Node root)
        {
            if (root != null)
            {
                GetAscendingOrder(root.m_Left);
                Console.Write(root.m_Value + " ");
                GetAscendingOrder(root.m_Right);
            }
        }
        /// <summary>
        /// printing the nodes in desending order 
        /// </summary>
        /// <param name="root">root node</param>
        private void GetDescendingOrder(Node root)
        {
            if (root != null)
            {
                GetDescendingOrder(root.m_Right);
                Console.Write(root.m_Value + " ");
                GetDescendingOrder(root.m_Left);
            }
        }
        /// <summary>
        /// Searching an elemnt in Binary Search Tree
        /// </summary>
        /// <param name="root">root node</param>
        /// <param name="element">element value to be searched</param>
        private void SearchNode(Node root, double element)
        {
            Node current = root;
            while (current != null)
            {
                if (element == current.m_Value)
                {
                    Console.WriteLine("\nElement {0} Found in the tree", element);
                    break;
                }
                else if (element < current.m_Value)
                {
                    current = current.m_Left;
                }
                else if (element > current.m_Value)
                {
                    current = current.m_Right;
                }
            }
            if (current == null)
            {
                Console.WriteLine("\nElement {0} not Found in the tree", element);
            }
        }
    }
}
