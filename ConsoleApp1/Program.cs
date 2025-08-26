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

string favorit_mat;
string viktig_del;
string fokusera;
string tilbehor;
Console.WriteLine("vad är din favorit mat");
favorit_mat = Console.ReadLine();
Console.WriteLine("vad är den viktigaste delen i din" + favorit_mat);
viktig_del = Console.ReadLine();
Console.WriteLine("vad är det man ska fokusera på för att få det perfekta " + viktig_del);
fokusera = Console.ReadLine();
Console.WriteLine("vad är det bästa tilbehöret t.ex ketscup på carbonara");
tilbehor = Console.ReadLine();

Console.WriteLine($"Den bästa maten i värden är {favorit_mat}. Hur skulle man kunna leva utan {favorit_mat}? Den bästa och viktigaste delen av en {favorit_mat} är {viktig_del} ");


