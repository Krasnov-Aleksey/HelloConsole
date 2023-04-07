// Площадь триугольника

// int[] coord = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int x1 = coord[0];
// int y1 = coord[1];
// int x2 = coord[2];
// int y2 = coord[3];
// int x3 = coord[4];
// int y3 = coord[5];
// double A = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// double B = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
// double C = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
// double p = (A + B + C) / 2;
// double S = Math.Sqrt(p * (p - A)  * (p - B) * (p - C));
// Console.WriteLine(S);
// void Zamena (int[,] matrix)
// {
//     int a=0;
//     int b=matrix.GetLength(0)-1;
//     for (int i=0; i<matrix.GetLength(1)-1;i++)
//     {
//         a=matrix[0,i];
//         matrix[0,i]=matrix[b,i];
//         matrix[b,i]=a;
//     }
// }


//Console.Clear();
// Console.Clear();
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размерность массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// Zamena(matrix);
// PrintMatrix(matrix);

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// void ReplaceRow(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// while (size[0] != size[1])
// {
//     Console.Write("Вы ошиблись!\nВведите размеры двумерного массива: ");
//     size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// }
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ReplaceRow(matrix);
// PrintMatrix(matrix);

// Console.Clear();
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(0, 11);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// int Pousk(int number,int []matrix)
// {

// }




// Console.Write("Введите размерность массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);



// foreach (int element in matrix)
// {
//     Console.Write(element);
// }

// bool checkElement(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//             return false;
//     }
//     return true;
// }

// int inputMatrix(int[,] matrix, int[] array)
// {
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             if (checkElement(array, matrix[i, j]))
//             {
//                 array[k] = matrix[i, j];
//                 k++;
//             }
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
//     return k;
// }


// void SwapFirstLastString(int[,] matrix, int[] array, int countArray)
// {
//     for (int k = 0; k < countArray; k++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {       
//                 if (array[k] == matrix[i, j])
//                     count++;
//             }
//         }
//         Console.WriteLine($"Элемент {array[k]} встречается {count} раз");
//     }

// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] coord = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// int[] array = new int[coord[0] * coord[1]];
// Console.WriteLine("Начальный массив: ");
// int countArray = inputMatrix(matrix, array);
// Console.WriteLine();
// Console.WriteLine($"[{string.Join(", ", array)}]");
// SwapFirstLastString(matrix, array, countArray);
//Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

// void MinPosMatrix(int [] matrix)
// {
//     int min = 0;
//     pos1=0;
//     pos2=0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i,j]<min)
//             {
//                 pos1=i;
//                 pos2=j;
//             }
//         }

//     }
// }
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();