// See https://aka.ms/new-console-template for more information

using DataStructuresAndAlgorithms.BigData;
using DataStructuresAndAlgorithms.BinarySearch;
using DataStructuresAndAlgorithms.BinarySearchTree;
using DataStructuresAndAlgorithms.LinearSearch;
using DataStructuresAndAlgorithms.LinkedList;
using DataStructuresAndAlgorithms.Queues;
using DataStructuresAndAlgorithms.Stack;
using System.Collections.Generic;


// Binarne drzewo poszukiwań – dynamiczna struktura danych będąca drzewem binarnym, w którym lewe poddrzewo
// każdego węzła zawiera wyłącznie elementy o kluczach mniejszych niż klucz węzła a prawe poddrzewo zawiera
// wyłącznie elementy o kluczach nie mniejszych niż klucz węzła

//Najpopularjniejsze drzewo
//Parents moze mieć tylko dwa węzły (node)

BinarySearchTree bst = new BinarySearchTree();
bst.Insert(7, "Squirtle");
bst.Insert(23, "Ekans");
bst.Insert(151, "Mew");
bst.Insert(4, "Charmander");
bst.Insert(1, "Bulbasaur");

Console.WriteLine(bst.Find(151));
int value = 0;