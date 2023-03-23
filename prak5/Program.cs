Console.Clear();
// Процедуры

// void f(ref int a)
// {
//     a = a + 10;
// }

// Console.Clear();
// int n = 5;
// f(ref n);
// Console.WriteLine(n);

// void f(int[] a)
// {
//     a[0] += 100;
// }

// Console.Clear();
// int[] array = {1, 2, 3, 4, 5};
// f(array);
// Console.WriteLine(string.Join(" ", array));
// int maxNumbers(int a, int b)
// {
//     if (a > b)
//         return a;
//     return b;
// }

// Console.Clear();
// int n = 10, m = 70;
// int result = maxNumbers(n, m);
// Console.WriteLine(result);
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// int SumPositiveNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             sum += array[i]; // sum = sum + array[i]
//     }
//     return sum;
// }

// int SumNegativeNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//             sum += array[i]; // sum = sum + array[i]
//     }
//     return sum;
// }


// Console.Clear();
// // Console.Write("Введите кол-во элементов в массиве: ");
// // int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[12];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Сумма положительных элементов равна {SumPositiveNumbers(array)}");
// Console.WriteLine($"Сумма отрицательных элементов равна {SumNegativeNumbers(array)}");

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

// void ChArray(int[] array)
// {
//     for (int i = 0; i< array.Length; i++)
//         array[i]=array[i]*-1;
// }

int Arr1099(int[] col)
{
    int index=0;
    for (int i=0;i<col.Length;i++)
    {
        if (col[i]>=10 && col[i]<=99)
        {
            index++;
        }
    }
    return index;
}

Console.Clear();
int[] array=new int[5];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(Arr1099(array));
//ChArray(array);
//Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
