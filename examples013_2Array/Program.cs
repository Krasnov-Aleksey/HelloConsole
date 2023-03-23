void InputDArray(int [,] col) //Создание двухмерного массива
{
    for (int i=0; i<col.GetLength(0);i++)
    {
        for (int j=0; j<col.GetLength(1);j++)
        {
            col[i,j]=new Random().Next(1,10);
            Console.Write(col[i,j]);
        }
        Console.WriteLine();
    }
}

Console.Clear();
int [,] arr= new int [3,5];
InputDArray(arr);









