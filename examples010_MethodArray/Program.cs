﻿// int[] array ={11,12,31,45,57,12,97,82};
// int n=array.Length;
// int find=12;
// int index=0;
// while(index<n)
// {
//     if (array[index]==find)
//     {
//         Console.WriteLine(index);
//         break;
//     }


//     index++;
// 
Console.Clear();
void FillArray(int[] collection)
{
    int length=collection.Length;
    int index=0;
    while(index<length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count=col.Length;
    int position=0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index=0;
    int position=0;
    while(index<count)
    {
        if(collection[index]==find)
        {
            position=index;
        }
        index++;
    }
    return position;
}
int [] array=new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos=IndexOf(array,4);
Console.WriteLine(pos);