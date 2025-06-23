//Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. 
//Просте число - це число, яке ділиться лише на 1 і на себе.

Console.WriteLine("Enter the number:");
int usersNumber = int.Parse(Console.ReadLine());

for (int num = 2; num <= usersNumber; num++)
{
  bool isPrime = true;
  for (int divideBy = 2; divideBy < num; divideBy++)
  {
    if (num % divideBy == 0)
    {
      isPrime = false;
      break;
    }
  }
  if (isPrime)
  {
    Console.Write(num + " ");
  }
}