/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/


Console.Write("Введите числа через запятую: ");
string? input = Console.ReadLine();
char splitSymbol = ',';
int count = 0;

int numbersCount = 1;
for(int i = 0; i < input.Length; i++)
{
if(input[i] == splitSymbol)
numbersCount++;
}
int[] numbers = new int[numbersCount];
int numberIndex = 0;
string subString = "";
for(int i = 0; i < input.Length; i++)
{
if(input[i] == splitSymbol)
{
numbers[numberIndex] = Convert.ToInt32(subString);
subString = "";
numberIndex++;
}
else
{
subString += input[i];
}
}
numbers[numberIndex] = Convert.ToInt32(subString);
for(int i = 0; i < numbers.Length; i++)
{
if(numbers[i] > 0)
{
count++;
}
}
Console.WriteLine($"Из них положительных чисел - {count}");