using System.Net;

Console.WriteLine("du har först in i ett spel tänk som jumanji du har tre liv");
int liv = 3;
int aura = 0;
Console.WriteLine("Du är i en jungel");
Console.WriteLine("du får välja mellan tre föremål, kniv, en pillbåge eller en pistol");
Console.WriteLine("vilket väljer du?");
string val = Console.ReadLine();
string inventory1;
while (val != "kniv" && val != "pillbåge" && val != "pistol")
{
    Console.WriteLine("du måste välja mellan kniv, pillbåge eller pistol (alla med små bokstäver)");
    val = Console.ReadLine();

    if (val == "kniv")
    {
        Console.WriteLine("bra vall du kommer inte behöva ora dig för skot eller pillar");
        inventory1 = "kniv";
    }
    else if (val == "pillbåge")
    {
        Console.WriteLine("bra val du kommer kunna sjuta tyst men ta vara på pillarna");
        inventory1 = "pillbåge";
    }
    else if (val == "pistol")
    {
        Console.WriteLine("bra val du kommer kunna skjuta snabbt men ta vara på skotten");
        inventory1 = "pistol";
    }
}
Console.WriteLine("nu har du dit valda föremål i ditt inventory men var vill du gå?");
Console.WriteLine("det finn tre stigar en tillvänster, höger och rakt fram");
Console.WriteLine("var går du?");
while(val != "vänster" && val != "höger" && val != "fram")
{
    Console.WriteLine("du måste välja mellan vänster, höger eller fram (alla med små bokstäver)");
    val = Console.ReadLine();

    if (val == "vänster")
    {
        Console.WriteLine("du forsäter gå på stigen tills du kommer till en liten katt");
        Console.WriteLine("du har tre vall du kan antingen klappa den, gå runt den eller döda den för mat");
        while (val != "klappa" && val != "gå runt" && val != "döda")
        {
            Console.WriteLine("du måste välja mellan klappa, gå runt eller döda (alla med små bokstäver)");
            val = Console.ReadLine();

            if (val == "klappa")
            {
                while (val != "sluta")
                {
                    int kattsur = Random.Shared.Next(100);
                    if (kattsur == 69)
                        Console.WriteLine("katten blir arg och river dig i ansiktet du förlorar ett liv");
                    liv = liv - 1;
                    Console.WriteLine("du har nu " + liv + " liv kvar");
                    Console.WriteLine("vill du forsätta klappa katten eller sluta?");
                    val = Console.ReadLine();
                    if (val == "sluta")
                    {
                        break;
                    }
                    else
                        Console.WriteLine("katten blir glad");
                    aura += 1;
                    Console.WriteLine("vill du forsätta klappa katten eller sluta?");
                    val = Console.ReadLine();
                    if (val == "sluta")
                    {
                        break;
                    }
                }

            }



            else if (val == "gå runt")
            {
                Console.WriteLine("katten blir arg och river dig i benet du förlorar ett liv");
                liv = liv - 1;
                Console.WriteLine("du har nu " + liv + " liv kvar");
            }
            else if (val == "döda")
            {
                Console.WriteLine("katten blir glad och låter dig fortsätta på stigen");
            }
        }
    } 



    else if (val == "höger")
        {
            Console.WriteLine("effter du gått en bit på stigen kommer en leopart springades till dig");
            Console.WriteLine("du har tre val, du kan försöka stå still och hopas på det bästa, springa eller använda ditt föremål och gå till anfall");
        }
    }
    Console.ReadLine();