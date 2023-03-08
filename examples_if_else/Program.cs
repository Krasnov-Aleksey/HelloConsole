Console.Write("Введите ваше имя ");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша")
{
    Console.WriteLine("Ура это Маша");
}
else
{
    Console.Write("Привет это ");
    Console.WriteLine(userName);
}