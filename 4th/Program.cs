//Напишіть програму, яка перевіряє пароль користувача. Пароль вважається прийнятним,
//якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра, а також принаймні 
//один символ - це спеціальний символ (наприклад, !, @, # тощо).

//я так розумію це треба робити через array :(

Console.WriteLine("Enter the password:");
string password = Console.ReadLine();
string specialChars = "!@#$%^&*()_+=;'/?[]{}";

while (password.Contains(specialChars))
{
  Console.WriteLine("pass is correct");
  if (!password.Contains(specialChars))
  {
    Console.WriteLine("wrong");
  }
}