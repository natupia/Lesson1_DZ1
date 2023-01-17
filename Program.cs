//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
Console.WriteLine($"{firstNumber} является большим числом, а {secondNumber} является меньшим числом");
}
else
{
Console.WriteLine($"{secondNumber} является большим числом, а {firstNumber} является меньшим числом");
}