// See https://aka.ms/new-console-template for more information
Add(1, 2);
Add(1, 2, 3, 4, 5);
int[] array = new int[] { 1, 2, 3, 4 };
Add(array);
Add();
static void Add(params int[] integers)
{
    int result = 0;
    for (int i = 0; i < integers.Length; i++)
    {
        result += integers[i];
    }
    Console.WriteLine(result);
}
