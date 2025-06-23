//Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, 
//та розмір годинної ставки. Після введення значень програма має обчислити та вивести оплату за день.

Console.WriteLine("Enter the salary per hour:");
int salaryPerHour = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the working hours per day:");
int hoursPerDay = int.Parse(Console.ReadLine());

while (salaryPerHour > 0)
{
  int totalEarnings = salaryPerHour * hoursPerDay;
  Console.WriteLine($"Total salary per day: {totalEarnings}");
  if (totalEarnings <= 0)
  {
    Console.WriteLine($"Total salary per day: 0");
    break;
  }
  break;
}

// маю відчуття, що це було зроблено складніше і неправильно, але воно працює :D

