﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.BinarySearchTree
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;
        public void Insert(int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }
        public TreeNode InsertItem(TreeNode node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);
            //If this is the first time you insert, create the root
            if (node == null)
            {
                node = newNode;
                return node;
            }

            //if this isnt the first inser, travese, find null, insert

            if (key < node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key,value);
            }
            else
            {
                node.RightChild = InsertItem(node.RightChild, key, value);
            }

            return node;
        }

        public string Find(int key)
        {
            TreeNode node = Find(Root, key);
            return node == null ? null : node.Value;
        }

        private TreeNode? Find(TreeNode node, int key)
        {
            if (node == null || node.Key ==key)
            {
                return node;
            }
            else if (key < node.Key)
            {
                return Find(node.LeftChild, key);
            }
            else if (key > node.Key)
            {
                return Find(node.RightChild, key);
            }
            return null;
           
            
           
        }

    }
}
