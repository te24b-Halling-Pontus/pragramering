// string name;

// Console.WriteLine("vad heter du?");
// name = Console.ReadLine();
// string posetivtord = "snälla";

// Console.WriteLine("hej hej");
// Console.WriteLine("Mvh " + name);
// Console.WriteLine($"idag tycker {name} att ni är {posetivtord} idag");



// Console.ReadLine();


using System.Runtime.CompilerServices;

string name;

Console.WriteLine("vad heter du?");
name = Console.ReadLine();

string favoritMat;
string viktigdel;
string fokusera;
string tilbehor;
Console.WriteLine("vad är din favorit mat");
favoritMat = Console.ReadLine();
if (favoritMat == "Tacos" || favoritMat == "taco")
{
    Console.WriteLine("bra val");
}
else
{
    Console.WriteLine("Finns godare");
}
Console.WriteLine("vad är den viktigaste delen i din " + favoritMat);
viktigdel = Console.ReadLine();
Console.WriteLine("vad är det man ska fokusera på för att få det perfekta " + viktigdel);
fokusera = Console.ReadLine();
Console.WriteLine("vad är det bästa tillbehöret t.ex ketchup på carbonara");
tilbehor = Console.ReadLine();

Console.WriteLine($"Den bästa maten i världen är {favoritMat}! Hur skulle man kunna leva utan {favoritMat}? för att få den bästa {favoritMat} måste man göra {viktigdel} rätt. Det gör man genom att fokusera på {fokusera}. Men man får inte häller glöma den viktiga {tilbehor} som krydar till {favoritMat}n lite. Det är så du får den perfekta {favoritMat}n!");
Console.WriteLine("Mvh " + name);


Console.ReadLine();