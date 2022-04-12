using Csharp_Shop_2;

Console.WriteLine("BENVENUTO NEL MIO PROGRAMMA!\n");

Acqua Acqua = new Acqua("Sant'anna", "Acqua più fresca non esiste!", 3, 11, 1, 7.6, "Monte Bianco");

Acqua.stampaProdotto();
Acqua.bevi(0.5);
Console.WriteLine(Acqua.litri);
Acqua.riempi(0.6);
Console.WriteLine(Acqua.litri);
Acqua.svuota();
Console.WriteLine(Acqua.litri);