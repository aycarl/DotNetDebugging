using System;

namespace DotNetDebugging
{
  class Node
  {
    public int value;
    public Node? left;
    public Node? right;

    public Node(int val)
    {
      this.value = val;
      this.left = null;
      this.right = null;
    }
  }


  class BinarySearchTree
  {
    public Node? root;

    public BinarySearchTree()
    {
      this.root = null;
    }

    public void insert(int val)
    {
      Node newNode = new Node(val);

      Console.WriteLine($"Inserting {val}");

      if (root == null) 
      {
        root = newNode;
      } else {
          
        var currentNode = root;

        bool inserted = false;

        while(inserted == false)
        {
          
          Console.WriteLine($"inserted is {inserted}");

          if (val < currentNode.value)
          {
            // left
            if (currentNode.left == null)
            {
              currentNode.left = newNode;
              inserted = true;
              Console.WriteLine($"inserted is {inserted}");
              //continue;
            } else {
              currentNode = currentNode.left;
            }
            
          } else {
            //right
            if (currentNode.right == null)
            {
              currentNode.right = newNode;
              inserted = true;
              Console.WriteLine($"inserted is {inserted}");
            } else {
              currentNode = currentNode.right;
            }
          }
        }
      }


    }

    public bool lookup(int val)
    {
      if (root == null)
      {
        return false;
      }

      Node currentNode = root;

      while (currentNode != null)
      {
        if (val < currentNode.value)
        {
          currentNode = currentNode.left;
        } 
        else if (val > currentNode.value)
        {
          currentNode = currentNode.right;
        } else {
          if (val == currentNode.value)
          {
            return true;
          }
        }
      }

      return false;
    }

    public void traverse()
    {
      if (root == null)
      {
        Console.WriteLine("Binary Search Tree is empty");
      } else {

        bool inComplete = false;

        var currentNode = root;

        while (inComplete)
        {
          
        }
      }
    }
  }
}