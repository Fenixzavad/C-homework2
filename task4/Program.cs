// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день
// выходным.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int NamberDay = Convert.ToInt32(Console.ReadLine());
    return NamberDay;
}

System.Console.WriteLine("Необходимо определить выходные дни недели!");
int day = Prompt("Введите номер дня недели: ");

if (day >= 1 & day < 6)
{
    System.Console.WriteLine("Это будний день!");
}
else 
{if(day >=6 & day <=7)
{
    System.Console.WriteLine("Это выходной день!");
}}