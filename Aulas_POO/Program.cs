using System;
using Aulas_POO;

var motocicleta = new Motocicleta("Honda", "CB500F");
motocicleta.Acelerar();
motocicleta.Frenar();
motocicleta.Abastecer();
motocicleta.EmitirSom();
Console.WriteLine(motocicleta);

Motocicleta.Esportiva minhaEsportiva = new Motocicleta.Esportiva("Yamaha", "YZF-R1", 998, "Azul");
minhaEsportiva.Acelerar();
minhaEsportiva.Frenar();
minhaEsportiva.Abastecer();
minhaEsportiva.EmitirSom();
minhaEsportiva.Empinar();
Console.WriteLine(minhaEsportiva);
