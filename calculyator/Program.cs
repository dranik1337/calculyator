Console.WriteLine("выберите действие");
Console.WriteLine("1-сложение");
Console.WriteLine("2-вычитание");
Console.WriteLine("3-умножение");
Console.WriteLine("4-деление");
string a = Console.ReadLine();
Console.WriteLine("введите первое значение");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе значение");
int numberr = Convert.ToInt32(Console.ReadLine());
if (a == "1")
{
    Console.WriteLine("результат сложения {0} ", number + numberr );
}
if (a == "2")
{
    Console.WriteLine("результат сложения {0} ", number - numberr);
}
if (a == "3")
{
    Console.WriteLine("результат сложения {0} ", number * numberr);
}
if (a == "4")
{
    Console.WriteLine("результат сложения {0} ", number / numberr);
}

  


