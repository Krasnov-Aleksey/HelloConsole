// //сложить 2 числа с помощью рекурсии
// // 5 6 -> 11
// int f(int a, int b)
// {
// if (a == 0)
// return b;
// return f(a - 1, b + 1);
// }

// Console.Clear();
// Console.WriteLine(f(5, 3));

// // f(5, 3) -> f(4, 4) -> f(3, 5) -> f(2, 6) -> f(1, 7) -> f(0, 8) -> 8

// string f(int n)
// {
// if (n == 1)
// return "1 ";
// return f(n - 1) + $"{n} ";
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(f(n));
// /*
// f(5) -> f(4) + "5 "
// |
// f(3) + "4 "
// |
// f(2) + "3 "
// |
// f(1) + "2 "
// |
// "1 "
// */

// string f(int n,int m)
// {
// if (n == m)
//     return $"{n} ";
// return f(n, m - 1) + $"{m} ";
// }


// Console.Clear();
// Console.Write("Введите число: ");
// // int n = int.Parse(Console.ReadLine()!);
// // int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine(f(2,8));

// int f(int n)
// {
// if (n < 10 || n / 10 == 0 || n % 10 == n)
// return n;
// return f(n / 10) + n % 10;
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(f(n));
// /*
// f(12345) -> f(1234) + 5
// |
// f(123) + 4
// |
// f(12) + 3
// |
// f(1) + 2
// |
// 1
// */

int f(int a,int b)
{
if (b==0)
return 1;
return f(a,b-1)*a;
}


Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(2,3));