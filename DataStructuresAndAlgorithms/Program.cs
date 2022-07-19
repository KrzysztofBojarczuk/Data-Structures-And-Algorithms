// See https://aka.ms/new-console-template for more information

using DataStructuresAndAlgorithms.BigData;

Big0 big = new Big0();
big.Description();


Console.WriteLine("===========");

//Array Insetion & Deletions 

int[] intArray = new int[10];

int length = 0;


for (int i = 0; i < 8; i++)
{
    intArray[length] = i+1;
    length++;
}

foreach (var item in intArray)
{
    Console.WriteLine(item);
}
Console.WriteLine("----");
//intArray[length] = 8;
//length++;

//Inserting at the start of an array

for (int i = 3; i >= 0; i--)
{
    intArray[i + 1] = intArray[i];
}

intArray[0] = 20;
int value = 0;

foreach (var item in intArray)
{
    Console.WriteLine(item);
}
Console.WriteLine("---");

for (int i = 4; i >= 2; i--)
{
    intArray[i + 1] = intArray[i];
}

intArray[2] = 8;
foreach (var item in intArray)
{
    Console.WriteLine(item);
}

//Deletions

Console.WriteLine("Deletions");
int[] intArray2 = new int[9];

int lengthh = 0;
for (int i = 0; i < 6; i++)
{
    intArray2[lengthh] = i;
    lengthh++;
}
//lengthh--;

for (int i = 1; i < lengthh; i++)
{
    intArray2[i - 1] = intArray2[i];
    length++;

}
lengthh--;

for (int i = 0; i < lengthh; i++)
{
    Console.WriteLine(intArray2[i]);
}

Console.WriteLine("----");
Console.WriteLine("Deleting From Anywhere in Array");
for (int i = 4; i < lengthh; i++)
{
    intArray2[i - 1] = intArray2[i];
}
lengthh--;
for (int i = 0; i < lengthh; i++)
{
    Console.WriteLine(intArray2[i]);
}