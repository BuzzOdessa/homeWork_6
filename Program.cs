// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8; // Інакше українське "і" не виводилось.
Console.Title = "Домашка №5";


do
{
    Console.WriteLine($"Введіть число у бінарному вигляді(тільки 0 та 1). Введення порожнього рядка це вихід із програми. ");
    var testStr = Console.ReadLine();
    if ( testStr.Trim() == "" )
        break;
    if (!Regex.Match(testStr, "^[01]+$").Success)
    {
        Console.WriteLine($"'{testStr}' не є числом у бінарному вигляді");
    }
    else
    {
        Console.WriteLine($"Введено число {Convert.ToUInt64(testStr, 2)}");
        if (Regex.Match(testStr, "0$").Value == "0")
        {
            Console.WriteLine("Його можна поділити на 2 без остачі");
        }
        else
        {
            Console.WriteLine("Воно не ділиться на 2 без остачі");
        }
    }
    Console.WriteLine("-----------------");
}
while (true);