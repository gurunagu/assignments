using System;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private Node Root=null;
        /// <summary>
        /// to store the root node position
        /// </summary>
        /// <returns>root node</returns>
        private Node GetRootNode()
        {
            return Root;
        }
        /// <summary>
        /// used to give control to the user
        /// </summary>
        public void UserControl()
        {
            int condition = 0;
            while (condition != 5)
            {
                Console.WriteLine("\noptions:\n1.Node creation\n2.Display Ascending order\n3.Display Desending order\n4.Search an Element\n5.exit");
                condition = int.Parse(Console.ReadLine());
                switch (condition)
                {
                    case 1:
                        {
                            Console.WriteLine("enter node element");
                            double num = double.Parse(Console.ReadLine());
                            this.InsertNode(num);
                            Console.Write("\nPress ENTER to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("\nascending order traversal : ");
                            this.GetAscendingOrder(this.GetRootNode());
                            Console.Write("\n\nPress ENTER to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("\ndescending order traversal : ");
                            this.GetDescendingOrder(this.GetRootNode());
                            Console.Write("\n\nPress ENTER to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("enter element to search in tree");
                            double element = double.Parse(Console.ReadLine());
                            this.SearchNode(this.GetRootNode(), element);
                            Console.Write("\nPress ENTER to continue");
                            Console.ReadLine();
                            break;
                        }
                }
            }
            Console.WriteLine("Press ENTER to Exit");
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
                //inserting node in the tree
                while (true)
                {
                    parentNode = currentNode;
                    //checking for Left side of tree
                    if (value < currentNode.m_Value)
                    {
                        currentNode = currentNode.m_Left;
                        if (currentNode == null)
                        {
                            parentNode.m_Left = newNode;
                            return;
                        }
                    }
                    //checking for right side of the tree
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
            while (root != null)
            {
                if (element == root.m_Value)
                {
                    Console.WriteLine("\nElement {0} Found in the tree", element);
                    break;
                }
                else if (element < Root.m_Value)
                {
                    root = root.m_Left;
                }
                else if (element > Root.m_Value)
                {
                    root = root.m_Right;
                }
            }
            if (root == null)
            {
                Console.WriteLine("\nElement {0} not Found in the tree", element);
            }
        }
    }
}
