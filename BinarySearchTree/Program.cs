﻿using BinarySearchTree;
using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree obj1 = new BinaryTree();
            obj1.Insert(56);
            obj1.Insert(30);
            obj1.Insert(70);
            obj1.TraversePreorder(obj1.root);
        }
    }
}
