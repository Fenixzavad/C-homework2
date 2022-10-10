// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе удаляет вторую цифру этого числа.


int Module(int module)

{
if (module < 0)
{
    module = -module;
}
return module;
}   

System.Console.WriteLine("Введите трехзначное чило: ");
int value = Convert.ToInt32(Console.ReadLine());

value = Module(value);
if (value > 99 & value <=999)
{
   int CorrectValue = (value/100)*10+(value%10);
   System.Console.WriteLine($"Выводим трехзначное число без десятков: {CorrectValue}");
}
else 
{
    System.Console.WriteLine("Это не трехзначное число");
}