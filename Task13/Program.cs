//  Выяснить, кратно ли число заданному, если нет, вывести остаток

int number1 = 22;
int number2 = 5;

if (number1 % number2 != 0)
{
    Console.Write(number1);
    Console.Write(" mod ");
    Console.Write(number2);
    Console.Write(" = ");
    Console.Write(number1 % number2);
}
else
{
    Console.Write(number1);
    Console.Write(" is multiply ");
    Console.Write(number2);
}