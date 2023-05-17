using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia telefone1 = new Nokia(numero: "9292929", modelo: "Nokia E5", imei: "1925612121", memoria: 8);
Console.WriteLine($"Telefone Nokia: {telefone1.Numero}");
telefone1.Ligar();
telefone1.InstalarAplicativo("WHATSAPP");

Console.WriteLine("\n");

Iphone telefone2 = new Iphone(numero: "9393939", modelo: "iPhone 8s PLUS", imei: "35628134", memoria: 128);
Console.WriteLine($"Telefone iPhone: {telefone2.Numero}");
telefone2.ReceberLigacao();
telefone2.InstalarAplicativo("TELEGRAM");
