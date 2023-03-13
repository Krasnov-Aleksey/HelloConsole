Console.Clear();
// Поиск индекса по значению в массиве
int findValueIndex(int[] col, int value)
{
    int length=col.Length;
    int index=0;
    while(index<length)
    {
        if (col[index]==value)
        {
            return index;
        }
        
    index++;
    }
return -1;
}

// Поиск максимального значения в массиве
int findMaxValue(int[] col)
{
    int length=col.Length;
    int index=0;
    int max=col[index];
    while(index<length)
    {
        if (col[index]>max)
        {
            max=col[index];
        }
        
    index++;
    }
    return max;
}

// Поиск максимального значение в диапазоне
int findMaxValueRange(int[]col, int begin, int end)
{
    int max=col[begin];
    while(begin<=end)
    {
        if (col[begin]>max)
        {
            max=col[begin];
        }
        
    begin++;
    }
    return max;
}

// Поиск второго максимального значение в диапазоне
int findSecondMaxValueRange(int[] col, int begin, int end) //,int ignore
{
    int ignore = findMaxValueRange(col, begin, end);
    int max2 = 0;
        
    while (begin <= end)
    {
        
        if (col[begin] < ignore)
        {
            if(col[begin]>max2)
            {
                max2=col[begin];
            }
        }

        begin++;

    }
    return max2;
}




int [] array={1,12,31,54,15,6,7,0,81,9,10};
// int position=findValueIndex(array,0);
// int max=findMaxValue(array);
// Console.WriteLine(position);
// Console.WriteLine(max);
//int maxrang = findMaxValueRange(array,1,9);
// Console.WriteLine(maxrang);
int maxsecondrang = findSecondMaxValueRange(array,1,10);
//Console.WriteLine(maxrang);
Console.WriteLine(maxsecondrang);