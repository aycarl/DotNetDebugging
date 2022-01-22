using System;
using System.Diagnostics;
using System.Collections;

namespace DotNetDebugging
{
    class Program
    {
      static void Main(string[] args)
      {

        // BINARY SEARCH TREE
        BinarySearchTree tree = new BinarySearchTree();
        tree.insert(9);
        tree.insert(4);
        tree.insert(6);
        tree.insert(20);
        tree.insert(170);
        tree.insert(15);
        tree.insert(1);

        Console.WriteLine(tree.lookup(200));

        Console.WriteLine("Ended");
        Console.ReadLine();

        //int result = Fibonacci(6);
        //Console.WriteLine(result);

        // int sum = 11;
        // int[] arr = new int[]{1, 3, 4, 9, 2};
        // int[] arr2 = new int[]{7, 3, 4, 9, 2};

        // Container with most water array problem
        // Console.WriteLine($"Largest Container in array: {ContainerWithMostWater(arr2)}");

        // TWO SUM array problem
        //var idxs = FindTwoSum(arr, sum);
        // var idxs = FindTwoSumOptimized(arr, sum);
        // Console.WriteLine($"SUM: {sum}");
        // Console.WriteLine($"PAIR: {idxs[0]},{idxs[1]}");
      }

      static int ContainerWithMostWater(int[] arr)
      {
        int maxArea = 0;
        int area = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
              area = Math.Min(arr[i], arr[j]) * (j - i);

                if (area > maxArea)
                {
                    maxArea = area;
                }
            }
        }

        return maxArea;
      }

      // static int Fibonacci(int n)
      // {
      //   //Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
      //   //Debug.WriteLine($"We are looking for the {n}th number");

      //   int n1 = 0;
      //   int n2 = 1;
      //   int sum = 0;

      //   for (int i = 2; i <= n; i++)
      //   {
      //     sum = n1 + n2;
      //     n1 = n2;
      //     n2 = sum;
      //     //Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
      //   }

      //   //Debug.Assert(n2 == 5, "The return value is not 5 and it should be");
      //   return n == 0 ? n1 : n2;
      // }

      // static int[] FindTwoSum(int[] nums, int sum)
      // {
      //   if (nums.Length < 2)
      //   {
      //     return new int[]{0, 0};
      //   }

      //   if (nums.Length == 2)
      //   {
      //     if (nums[0] + nums[1] == sum) return new int[]{0, 1};
      //   }

      //   for (int i = 0; i < nums.Length; i++)
      //   {
      //     for (int j = i+1; j < nums.Length; j++)
      //     {
      //       if ((nums[i] + nums[j]) == sum)
      //       {
      //         Debug.WriteLine($"pair found: {i}, {j}");
      //           return new int[]{i, j};
      //       }
      //     }
      //   }

        
      //   return new int[]{0, 0};
      // }

      // static int[] FindTwoSumOptimized(int[] nums, int target)
      // {
      //   // to store the difference as a key and location/indx as a value
      //   Hashtable sumDiff = new Hashtable();

      //   for (int i = 0; i < nums.Length; i++)
      //   {
      //       int numToFind = target - nums[i];
      //       sumDiff[numToFind] = i;
      //       Debug.WriteLine($"Key: {numToFind}, Value: {i}");
      //       if (sumDiff[nums[i]] > 0)
      //       {
      //           return new int[]{(Int32)sumDiff[target - numToFind], i};
      //       }
      //   }

      //   return new int[]{0, 0};
      // }
    }
}