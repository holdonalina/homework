//Напишіть програму, яка перевіряє,
//чи є задане користувачем число простим. Число вважається простим, якщо воно ділиться лише на 1 і на себе.

Console.WriteLine("Enter the number:");
int usersNumber = int.Parse(Console.ReadLine());
bool isPrime = true;

if (usersNumber < 2)
{
  isPrime = false;
  Console.Write("The number is not prime");
}

for (int i = 2; i < usersNumber; i++)
{
  if (usersNumber % i == 0)
  {
    isPrime = false;
    Console.Write("The number is not prime");
    break;
  }
  if (isPrime)
  {
    Console.Write("The number is prime");
    break;
  }
}