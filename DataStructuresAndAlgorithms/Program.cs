// See https://aka.ms/new-console-template for more information

using DataStructuresAndAlgorithms.BigData;
using DataStructuresAndAlgorithms.BinarySearch;
using DataStructuresAndAlgorithms.BinarySearchTree;
using DataStructuresAndAlgorithms.BubbleSort;
using DataStructuresAndAlgorithms.LinearSearch;
using DataStructuresAndAlgorithms.LinkedList;
using DataStructuresAndAlgorithms.Queues;
using DataStructuresAndAlgorithms.Stack;
using System.Collections.Generic;




int[] intArray = new int[] { 6, 5, 1, 7, 2, 4 };
BubleSortClass bubleSortClass = new BubleSortClass();
var sortArray = bubleSortClass.BubbleSort(intArray);
foreach (var item in sortArray)
{
    Console.WriteLine(item);
}