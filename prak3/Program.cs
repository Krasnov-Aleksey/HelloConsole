Console.Clear();

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

int [] array={1,2,3,4,5,6,7,0,8,9,10};
int position=findValueIndex(array,12);
Console.WriteLine(position);

