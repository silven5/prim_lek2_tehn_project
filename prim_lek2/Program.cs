// See https://aka.ms/new-console-template for more information
var a = 5;
Console.WriteLine($"Початкове знаяення {a}",a);
IncrementVal(a);
Console.WriteLine($"Змінна післі передачі як значення {a}", a);
IncrementRef(ref a);
Console.WriteLine($"Змінна післі передачі за посиланням {a}", a);
void IncrementVal(int x)
{
    x++;
    Console.WriteLine($"IncrementVal: {x}", x);
}
void IncrementRef(ref int x)
{
    x++;
    Console.WriteLine($"IncrementRef: {x}", x);
}
