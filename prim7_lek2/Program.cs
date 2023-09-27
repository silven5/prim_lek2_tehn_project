using prim7_lek2;

People people = new People();
people[0] = new Person ("Tom",18 );
people[1] = new Person ("Bob", 25);
Console.WriteLine($"{people[0].Name} {people[0].Age}");      // Tom
Console.WriteLine($"{people["Bob"]?.Name} {people["Bob"]?.Age}");  // Bob

