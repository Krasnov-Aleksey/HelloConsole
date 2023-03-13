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





int [] array={1,2,3,4,5,6,7,0,8,9,10};
int position=findValueIndex(array,0);
int max=findMaxValue(array);
Console.WriteLine(position);
Console.WriteLine(max);