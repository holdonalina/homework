// Напишіть програму, яка будує графік за допомогою зірочок. Користувач повинен ввести кількість рядків графіка. 
// Кожен рядок графіка має містити відповідну кількість зірочок.

Console.WriteLine("Enter the number of rows:");
int rows = int.Parse(Console.ReadLine());

for (int i = 1; i <= rows; i++)
{
  for (int j = 1; j <= i; j++)
  {
    Console.Write("*");
  }
  Console.WriteLine();
}