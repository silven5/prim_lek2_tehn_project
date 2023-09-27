// See https://aka.ms/new-console-template for more information
var a = 10;
var b=2;
GetDate(a, b, out int S, out int P);
Console.WriteLine($"Площа = {S} Перметер = {P}", S, P);
//Приклад для in
a = 15;b = 3;
GetDateIn(a, b, out S, out  P);
Console.WriteLine($"Площа = {S} Перметер = {P}", S, P);
void GetDate(int a,int b,out int S, out int P)
{
    
    S = a * b;
    P = (a + b) * 2;
}
void GetDateIn(in int a, in int b, out int S, out int P)
{
    
    S = a * b;
    P = (a + b) * 2;
}
