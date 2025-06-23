//Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць. 
//Після отримання всіх значень програма має обчислити та вивести середній заробіток.

Console.WriteLine("Enter the number of employees");
int employee = int.Parse(Console.ReadLine());
int i = 0;
int totalEarnings = 0;

do
{
  Console.WriteLine($"Enter salary of the employee #{++i}");
  int salary = int.Parse(Console.ReadLine());

  Console.WriteLine($"Enter the amount of working days");
  int workingDays = int.Parse(Console.ReadLine());

  int monthlySalary = salary * workingDays;
  totalEarnings += monthlySalary;
}
while (i < employee);

double averageEarnings = (double)totalEarnings / employee;
Console.WriteLine($"Average monthly earnings of employees: {averageEarnings}");