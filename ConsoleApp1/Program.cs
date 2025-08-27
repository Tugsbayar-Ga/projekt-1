string name;
string gammal;
string du;

Console.WriteLine("ditt namn");
name = Console.ReadLine();
Console.WriteLine("Hur gammal är du? ");
gammal = Console.ReadLine();
Console.WriteLine("varför skriver du de");
du = Console.ReadLine();
Console.WriteLine($"Så du heter {name} och {gammal} år, varför skriv du {du}");
Console.ReadLine();