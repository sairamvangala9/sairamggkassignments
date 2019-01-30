using System;
using System.Collections.Generic;
using System.Linq;
namespace BinarySearchTree
{
    class Node
    {
        public Node left;
        public Node right;
        public int data;
        public Node(int x)
        {
            data=x;
        }
    }
    class BinarySearchTree
    {
        private List<int> nodes=new List<int>();
        public Node rootNode;
        public BinarySearchTree(int[] list)
        {
            nodes.AddRange(list);
            nodes=nodes.Distinct().ToList();
            nodes.Sort();
            int intMid=(list.Length%2==0)?list.Length/2:(list.Length-1)/2;
            rootNode=new Node(nodes[intMid]);
            BuildTree(nodes,rootNode);
        }
        public Node BuildTree(List<int> list,Node root)
        {
            Node t=root;
            int intright,intleft;Node temp=null;
            List<int> tempOne=new List<int>();
            List<int> tempTwo=new List<int>(); 
            int intMid=(list.Count%2==0)?list.Count/2:(list.Count-1)/2;
            for(int i=0;i<intMid;i++)
            {
                tempOne.Add(list[i]);
            }
            if(tempOne.Count!=0)
            {
                intright=(tempOne.Count%2==0)?tempOne.Count/2:(tempOne.Count-1)/2;
                t.left=BuildTree(tempOne,new Node(tempOne[intright]));
                temp=t.left;
            }
            for(int i=intMid+1;i<list.Count;i++)
            {
                tempTwo.Add(list[i]);
            }
            if(tempTwo.Count!=0)
            {
                intleft=(tempTwo.Count%2==0)?tempTwo.Count/2:(tempTwo.Count-1)/2;
                t.right=BuildTree(tempTwo,new Node(tempTwo[intleft]));
                temp=t.right;
            }
            return t;
        }
        /// <summary>
        /// This method prints the inorder of given BinaryTree
        /// </summary>
        /// <param name="parent"></param>
        public void InOrder(Node parent)
        {
            Node temp=parent;
            if(temp.left!=null)
            {
                InOrder(temp.left);
            }
            if(temp!=null){
                Console.Write(temp.data+"  ");
            }
            if(temp.right!=null)
            {
                InOrder(temp.right);
            }
        }
        /// <summary>
        /// this method traverses through the Binary Tree and prints the reverse inorder
        /// </summary>
        /// <param name="parent"></param>
        public void InOrderReverse(Node parent)
        {
            Node temp=parent;
            if(temp.right!=null)
            {
                InOrderReverse(temp.right);
            }
            if(temp!=null){
                Console.Write(temp.data+"  ");
            }
            if(temp.left!=null)
            {
                InOrderReverse(temp.left);
            }
        }
        /// <summary>
        /// search methods takes input key and searches for that key in its object tree
        /// if key is found it returns bool value as true else false
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Search(int key)
        {
            bool flag=false;
            Node temp=this.rootNode;
            while(temp!=null)
            {
                temp=(key>temp.data)?temp.right:temp.left; 
                if(temp!=null&&key==temp.data)
                {
                    flag=true;
                    break;
                }
            }
            return flag;
        }
    }
    /// <summary>
    /// main class takes input from console and prints inorder and reverse inorder of given Binary Tree
    /// </summary>
    public class Program 
    {
        public static void MainProgram()
        {
            
            Console.WriteLine("Enter integers with space into the binary tree");
            int[] numbers=Console.ReadLine().Split().Select(int.Parse).ToArray();
            BinarySearchTree BSTobject=new BinarySearchTree(numbers);
            Console.WriteLine("Inorder");
            BSTobject.InOrder(BSTobject.rootNode);
            Console.WriteLine("\nInorder Reverse");
            BSTobject.InOrderReverse(BSTobject.rootNode);
            Console.WriteLine("\nEnter element you want to search for: ");
            if(BSTobject.Search(Int32.Parse(Console.ReadLine())))
            {
                Console.WriteLine("The given element is found in the Binary Tree");
            }
            else
            {
                Console.WriteLine("The given element is not found in the Binary Tree");
            }
            Console.ReadLine();
        }
    }
}