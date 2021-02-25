using System;

namespace BinariTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var btr =  new BTree<int>();           

            var root = new BNode<int>(5);
            var firstLevelRightNode = new BNode<int>(7);
            var firstLevelLeftNode = new BNode<int>(27);
            var secondRightLevelRightNode = new BNode<int>(33);
            var secondRightLevelLeftNode = new BNode<int>(10);
            var secondLeftLevelRightNode = new BNode<int>(1);
            var secondLeftLevelLeftNode = new BNode<int>(333);


            firstLevelLeftNode.left = secondLeftLevelLeftNode;
            firstLevelLeftNode.right = secondLeftLevelRightNode;
            firstLevelRightNode.left = secondRightLevelLeftNode;
            firstLevelRightNode.right = secondRightLevelRightNode;
            root.right = firstLevelRightNode;
            root.left = firstLevelLeftNode;
            btr.Add(root);
            btr.Print();
        }
    }
}