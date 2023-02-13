//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a < 0)
{
    a = a*-1;
}
   
if (a > 100)
{
   while (a > 999) 
   {
    a = a / 10; 
   }
   int a1 = a % 10;
   Console.WriteLine(a1);
}
else 
Console.WriteLine($"Число {a} двухзначное , третье цифра отсутвует");




