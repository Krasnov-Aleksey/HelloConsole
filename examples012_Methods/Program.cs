// //Вид 1 (нечего не возрашают)
// void Method1()
// {
//     Console.WriteLine("Привет!");
// }
// Method1();

// // Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Ура");

// Вид 2.1
// void Method21(string msg, int x)
// {
//     int i=0;
//     while(i<x)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//Method21("Ура",3);
//Method21(x:3,msg:"Hello");

// Метод3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
//int year=Method3();
//Console.WriteLine(year);

// Метод4
// string Method4(int count, string text2)
// {
//     int i=0;
//     string result=String.Empty; //Пустая строка
    
//     while(i<count)
//     {
//         result=result+text2;
//         i++;
//     }
//     return result;
// }
// string res=Method4(10,"q");
// Console.WriteLine(res);
Console.Clear();
void SeeArr(int[] col)
{
    for (int i=0;i<col.Length;i++)
    {
        Console.Write(col[i]);
    }
    Console.WriteLine();
}

void SortArrMinMax (int [] col)
{
    for (int i=0; i<col.Length; i++)
    {
        int minPos=i;
        for(int j=i+1; j<col.Length;j++)
        {
            if (col[j]<col[minPos])
            { 
                minPos=j;
            }
        }
        int change=col[i];
        col[i]=col[minPos];
        col[minPos]=change;

    }

}
void SortArrMaxMin (int [] col)
{
    for (int i=0; i<col.Length; i++)
    {
        int maxPos=i;
        for(int j=i+1; j<col.Length;j++)
        {
            if (col[j]>col[maxPos])
            { 
                maxPos=j;
            }
        }
        int change=col[i];
        col[i]=col[maxPos];
        col[maxPos]=change;

    }

}

int[] array={2,1,9,6,3,5};
SeeArr(array);
SortArrMinMax(array);
SeeArr(array);
SortArrMaxMin(array);
SeeArr(array);



