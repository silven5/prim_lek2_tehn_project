// See https://aka.ms/new-console-template for more information
var turple = GetValues();
Console.WriteLine($"Value1={turple.Item1} Value={turple.Item2}", 
    turple.Item1,
    turple.Item2);
var turple1 = GetArray(new int[] { 1, 2, 3, -5, 12, 100 });
Console.WriteLine($"Кількість={turple1.count} Сума={turple1.sum} " +
    $"Сер.арфв={turple1.sa}",
    turple1.count,
    turple1.sum,
    turple1.sa);
(int,int) GetValues()
{
    var result = (1, 4);
    return result;
}
//полям можна надавати ім'я
(int sum,int count,double sa) GetArray(int[] numbers)
{
    var result = (sum: 0, count: 0,sa:0.0);
    foreach (var number in numbers)
    {
        result.count++;
        result.sum += number;
    }
    result.sa=result.sum/result.count;
    return result;
}
