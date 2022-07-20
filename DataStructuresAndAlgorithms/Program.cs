// See https://aka.ms/new-console-template for more information

using DataStructuresAndAlgorithms.BigData;
using DataStructuresAndAlgorithms.LinearSearch;

int[] array = new int[] {1,2,3,4,5,6,7,8,9,10 };

LinearSearchArray linearSearchArray = new LinearSearchArray();

Console.WriteLine(linearSearchArray.LinearSearch(array,10));
Console.WriteLine("===");
Console.WriteLine(linearSearchArray.LinearSearchWhile(array,10));