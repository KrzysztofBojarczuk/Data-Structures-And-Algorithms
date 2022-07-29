// See https://aka.ms/new-console-template for more information

using DataStructuresAndAlgorithms.BigData;
using DataStructuresAndAlgorithms.BinarySearch;
using DataStructuresAndAlgorithms.BinarySearchTree;
using DataStructuresAndAlgorithms.BubbleSort;
using DataStructuresAndAlgorithms.HashTable;
using DataStructuresAndAlgorithms.LinearSearch;
using DataStructuresAndAlgorithms.LinkedList;
using DataStructuresAndAlgorithms.Queues;
using DataStructuresAndAlgorithms.Recursion;
using DataStructuresAndAlgorithms.Stack;
using System.Collections.Generic;



// Hash Tables tables with key values pairs


HashTable hashTable = new HashTable();
hashTable.Set("Teddy", "656-778-4949");
hashTable.Set("Steve", "656-979-5454");
hashTable.Set("Jessica", "878-416-1545");
hashTable.Set("Sara", "944-144-1964");
hashTable.Set("Jennifer", "434-343-3434");

Console.WriteLine(hashTable.Get("Teddy"));
Console.WriteLine(hashTable.Get("Steve"));
Console.WriteLine(hashTable.Get("Jessica"));
Console.WriteLine(hashTable.Get("Sara"));
Console.WriteLine(hashTable.Get("Jennifer"));
