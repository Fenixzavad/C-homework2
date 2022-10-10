// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Module(int module)

{
if (module < 0)
{
    module = -module;
}
return module;
}   

System.Console.WriteLine("Найдем еденицы трехзначного числа! ");
int value = Prompt("Введите трехзначное чило: ");

value = Module(value);
int criate1=0;
if (value >=100 & value <= 999)
{
   criate1 = (value %10);
   System.Console.WriteLine(($"Выводим единицы трехзначного числа {criate1}"));
}
else 
{
    System.Console.WriteLine("Это не трехзначное число");
}