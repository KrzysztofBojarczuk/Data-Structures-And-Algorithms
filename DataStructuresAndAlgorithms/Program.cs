// See https://aka.ms/new-console-template for more information

using DataStructuresAndAlgorithms.BigData;
using DataStructuresAndAlgorithms.LinearSearch;
using DataStructuresAndAlgorithms.LinkedList;
using DataStructuresAndAlgorithms.Stack;
using System.Collections.Generic;

// Kolekcje - przetrzymują elementy kolekcji jako obiekty. last-in-first-out 
// push pop peek

Stack stack = new Stack(10);

for (int i = 0; i < 3; i++)
{
    stack.Push("Squitle");
    stack.Push("Pickachu");
    stack.Push("Chamralnder");
    
}

stack.Pop();
stack.Peek();


while (!stack.isEmpty())
{
    var var = stack.Pop();
    Console.WriteLine(var);
}

