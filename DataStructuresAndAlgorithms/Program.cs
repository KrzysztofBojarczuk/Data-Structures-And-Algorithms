﻿// See https://aka.ms/new-console-template for more information

using DataStructuresAndAlgorithms.BigData;
using DataStructuresAndAlgorithms.LinearSearch;
using DataStructuresAndAlgorithms.LinkedList;

Node nodeA = new Node();
nodeA.Data = 865;
Node nodeB = new Node();
nodeB.Data = 344;
Node nodeC = new Node();
nodeC.Data = 888;
Node nodeD = new Node();
nodeD.Data = 222;

nodeA.Next = nodeB;
nodeB.Next = nodeC;
nodeC.Next = nodeD;

Console.WriteLine("===");


LinkedList linkedList = new LinkedList();
linkedList.InsertFirst(1);
linkedList.InsertFirst(2);
linkedList.InsertFirst(3);
linkedList.InsertFirst(4);


linkedList.DeleteFirst();
linkedList.DeleteFirst();

linkedList.InsertLast(546);
linkedList.InsertLast(3434);

linkedList.DisplayList();