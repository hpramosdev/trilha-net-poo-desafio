using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia (numero: "999696852", modelo: "N1110", iMEI: "555", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nIphone");
Smartphone iphone = new Iphone (numero: "999696852", modelo: "10S", iMEI: "111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");