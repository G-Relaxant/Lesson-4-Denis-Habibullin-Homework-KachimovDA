/*int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
PrintAr(array);



void PrintAr(int[] a)
{
    Console.Write("[");
    for(int i = 0; i < a.Length;)           // Эта прога сама задаёт случайные значения массиву
    {
        Console.Write(a[i]);
        i++;
        if(i < a.Length)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}*/




// Эта прога вносит значения в массив из консоли

int[] array = new int[8];
int inp = 0;
InputAr(array, inp);
if(inp > -1 && inp < 100)       // Проверка корректности введённого числа
{
    PrintAr(array);     // Результат программы
}



void InputAr(int[] a, int b)        // Запись массива(метод)
{
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write("Введите число от 0 до 99: ");
        b = Convert.ToInt32(Console.ReadLine());
        if(b > -1 && b < 100)                           // Проверка корректности введённого числа
        {
            a[i] = b;
        }
        else
        {
            inp = b;
            Console.Write("Необходимо вводить число от 0 до 99, перезапустите программу и попробуйте ещё раз");
            break;
        }    
    }
}

void PrintAr(int[] a)           // Печать массива(метод)
{
    Console.Write("Массив из ваших чисел: [");
    for(int i = 0; i < a.Length;)
    {
        Console.Write(a[i]);
        i++;
        if(i < a.Length)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}