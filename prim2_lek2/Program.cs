// See https://aka.ms/new-console-template for more information
int[] array = { 1, 2, -39, 45, 33, 7, 99, 45, -78 };
Show(array);
Console.WriteLine("Введіть число яке буде замінено на 9");
int x = Convert.ToInt32(Console.ReadLine());
ref int place = ref Find(x, array);
place = 9;
Show(array);
//Метод повертає посилання на позицію шуканого елементу
static  ref int Find(int number, int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == number)
        {
            return ref numbers[i];
        }
    }
    throw new IndexOutOfRangeException($"{nameof(number)} not found");
}
static void Show(int[] numbers)
{
    Console.WriteLine("Масив дорівнює");
    foreach (int a in numbers)
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}
