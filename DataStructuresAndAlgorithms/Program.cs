// See https://aka.ms/new-console-template for more information

using DataStructuresAndAlgorithms.BigData;
using DataStructuresAndAlgorithms.LinearSearch;
using DataStructuresAndAlgorithms.LinkedList;
using DataStructuresAndAlgorithms.Queues;
using DataStructuresAndAlgorithms.Stack;
using System.Collections.Generic;

// Kolekcje - przetrzymują elementy kolekcji jako obiekty.
// Queue First In First Out


Queue queue = new Queue(10);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

queue.Dequeue();
queue.Dequeue();

queue.Peek();