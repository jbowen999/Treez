using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treez
{
    public class BinarySearchTree
    {
        private Node<int>? Root;
        private int Count = 0;

        public bool DoesValueExist(int valuesToFind)
        {
            Node<int> currentNode = Root;

            while (currentNode != null)
            {
                if(currentNode.Data == valuesToFind) 
                    return true;
                else if(currentNode.Data == valuesToFind)
                {
                    currentNode = currentNode.Left;
                } else
                {
                    currentNode = currentNode.Right;
                }
            }
            return false;

        }
        public void Insert(int data)
        {
            Node<int> newNode = new Node<int>(data);
            InsertHelper(newNode, Root);
            

        }

        public void InsertHelper(Node<int> newNode, Node<int>? currentNode)
        {
            if (Root == null)
            {
                Root = newNode;
                Count++;
                return;
            }

            //go left
            if (newNode.Data <= currentNode.Data)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                }
                else
                {
                    InsertHelper(newNode, currentNode.Left);
                }

            }
            else // go right
            {

            }
        }
    }
}
