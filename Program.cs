using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
  var nokia = new Nokia("999589623", "Galaxy Note 10", "78985", 128);
 nokia.Ligar();
 nokia.InstalarAplicativo("Twiter");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
var  Iphone = new Iphone("78955236", "Iphone 11 ", "987851", 128);
 Iphone.ReceberLigacao();
 Iphone.InstalarAplicativo("Telegram");
