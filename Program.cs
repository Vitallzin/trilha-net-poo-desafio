using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste de Smartphones\n");
Console.WriteLine("Teste do iPhone:");
Iphone iphone = new Iphone("123456789", "iPhone 13", "IMEI123456789", "128GB");
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nTeste do Nokia:");
Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654321", "16GB");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");