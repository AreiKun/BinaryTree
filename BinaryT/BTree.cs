
using System.Collections.Generic;
using System.Text;

namespace BinaryT
{
    class BTree
    {
        private BNode _root;
        private int _count;
        private IComparer<int> _comparer = Comparer<int>.Default;


        public BTree()
        {
            _root = null;
            _count = 0;
        }

        public bool Add(int Item)
        {
            if (_root == null)
            {
                _root = new BNode(Item);
                _count++;
                return true;
            }
            else
            {
                return Add_Sub(_root, Item);
            }
        }

        private bool Add_Sub(BNode Node, int Item)
        {
            if (_comparer.Compare(Node.item, Item) < 0)
            {
                if (Node.right == null)
                {
                    Node.right = new BNode(Item);
                    _count++;
                    return true;
                }
                else
                {
                    return Add_Sub(Node.right, Item);
                }
            }
            else if (_comparer.Compare(Node.item, Item) > 0)
            {
                if (Node.left == null)
                {
                    Node.left = new BNode(Item);
                    _count++;
                    return true;
                }
                else
                {
                    return Add_Sub(Node.left, Item);
                }
            }
            else
            {
                return false;
            }
        }

        public bool AddRight(BNode Node, int Item)
        {            
          if (Node.right == null)
             {
               Node.right = new BNode(Item);
               _count++;
                 return true;
             }
          else
             {
                return AddLeft(Node.left, Item);
            }            
        }

        public bool AddLeft(BNode Node, int Item)
        {
            if (Node.left == null)
            {
                Node.left = new BNode(Item);
                _count++;
                return true;
            }
            else
            {
                return AddRight(Node.left, Item);
            }
        }

        public BNode Root { get { return _root; } }

        public void Print()
        {
            Root.Print();
        }
    }
}
