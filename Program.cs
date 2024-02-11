// See https://aka.ms/new-console-template for more information
using Animal;

Console.WriteLine("Animal");
Console.WriteLine();

Perro  perro = new Perro();

Gato gato = new Gato();

Console.WriteLine("Mi perro:");
perro.HacerSonido();
Console.WriteLine();
Console.WriteLine("Mi gato:");
gato.HacerSonido();

