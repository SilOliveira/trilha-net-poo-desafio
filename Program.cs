using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero:"123", modelo: " modelo 1", imei:"111111111", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("discord");


Console.WriteLine("\n");


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero:"456", modelo: " modelo 2", imei:"2222222", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Busu");
