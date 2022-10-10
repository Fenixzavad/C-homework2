// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.


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

int secondNamber = 0;
value = Module(value);
if (value > 99 & value <=999)
{
   secondNamber = (value/10)%10;
   System.Console.WriteLine($"Вторая цифра трехзначного числа равна: {secondNamber}");
}
else 
{
    System.Console.WriteLine("Это не трехзначное число");
}