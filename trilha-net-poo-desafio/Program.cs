using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("98745666", "xpto", "vkvna4564", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Uber");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("65421225", "007", "KHHUGGY455", 32);
iphone.Ligar();
iphone.InstalarAplicativo("Zafari");

