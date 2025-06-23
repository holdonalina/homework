// Напишіть програму, яка генерує перші N чисел Фібоначчі. 
//Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.

int numberTo = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;

while (a <= numberTo)
{
  Console.WriteLine(a + " ");
  int nextNumber = a + b;
  a = b;
  b = nextNumber;
}

//або

for (int i = 0; a <= numberTo; i++)
{
  Console.WriteLine(a + " ");

  int nextNumber = a + b;
  a = b;
  b = nextNumber;
}

//гуглила формули, але заплуталась у тому, як їх використовувати