using DesafioPOO.Models;

Nokia nokia = new Nokia("123456789", "Nokia 3310", 123456789, "32GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake"); 

Iphone iphone = new Iphone("987654321", "iPhone 12", 987654321, "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");