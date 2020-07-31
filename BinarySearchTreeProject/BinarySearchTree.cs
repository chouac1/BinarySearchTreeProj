using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class BinarySearchTree
    {
        //member variables
        public Node Root;
        public Node LastNode;

        //constructor
        public BinarySearchTree()
        {

        }

        //methods

        public void AddNodeData(Node nodeToAdd)
        {
            if (Root == null)
            {
                Root = nodeToAdd;
                LastNode = nodeToAdd;
            }
            else
            {
                LastNode.NextNode = nodeToAdd;
                LastNode = nodeToAdd;
            }
        }

        public void SearchValues() 
        {
            
        }
    }
}
