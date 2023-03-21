Console.Clear();
Console.WriteLine("Введите число ");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);
int i=0;
while(num!=0)
{
    i++;
    num=num/10;
}
Console.WriteLine(i);

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 0;
// while (n != 0)
// {
//     count++;
//     n = n / 10; // n /= 10
// }
// Console.WriteLine(count);

// Array
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // [1, 10]
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Array
// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат {(1 + n) / 2 * n}");