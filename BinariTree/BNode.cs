using System;
using System.Collections.Generic;
using System.Text;

namespace BinariTree
{
    public class BNode<T> where T : IComparable
    {
        
        public BNode(T data)
        {
            Data = data;
        }
                
        public T Data { get; set; }
      
        public BNode<T> left { get; set; }
        
        public BNode<T> right { get; set; }       
       
    }
}
