int num = Input("Введите число: ");
int div = 10;
int razr = 1;
for(int cel = num; cel >= 10;)
{
    cel = num / div;
    div = div * 10;
    razr = razr + 1;
}
//Console.WriteLine("Разрядов в числе: " + razr);

div = 10;
int div2 = 10;
int sum = num % div;
int znach = 0;

for(int i = razr; i > 1;)
{
    i = i - 1;
    div = div * 10;
    znach = num % div;
    znach = znach / div2;
    div2 = div2 * 10;
    sum = sum + znach;
}

Console.Write("Сумма цифр числа: " + sum);



int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
