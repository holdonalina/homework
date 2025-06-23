//Напишіть програму, яка запитує в користувача число, 
//а потім генерує таблицю множення для цього числа від 1 до 10.

Console.WriteLine("Enter your number:");
int usersNumber = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
  int result = usersNumber * i;
  Console.WriteLine($"{usersNumber} * {i} = {result}");
}