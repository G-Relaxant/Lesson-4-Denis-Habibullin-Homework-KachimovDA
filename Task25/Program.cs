double num = Input("Введите число 1: ");
double num2 = Input("Введите число 2: ");
double product = num;
for(int i = 1; i < num2; i++)
{
    product = product * num;
}
Console.Write("Число 1 в степени числа 2: " + product);



double Input(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}