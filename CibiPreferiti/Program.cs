// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibi = { "calamari fritti", "panino alla salamella", "pizza", "formaggio", "cereali","lol" };
Console.WriteLine("la lunghezza della dell array è: " + cibi.Length);

for(int i = 0; i <= cibi.Length -1; i++)
{
    Console.WriteLine(cibi[i]);

    

}
var mediana = cibi.Length / 2;
if (mediana % 1 == 0)
{
    Console.WriteLine("la posizione mediana è: " + cibi[mediana]);
}
else
{
    Console.WriteLine(cibi[mediana]);
}



Console.WriteLine("prima posizione della classifica: " + cibi[0]);
Console.WriteLine("ultima posizione della classifica: " + cibi[cibi.Length - 1]);
