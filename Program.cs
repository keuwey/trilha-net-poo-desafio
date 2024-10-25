using DesafioPOO.Models;


Nokia nokia = new();
nokia.Ligar();
nokia.Numero = "71983903918";
nokia.ReceberLigacao();

Iphone iphone = new("71983903918");
iphone.Ligar();
iphone.ReceberLigacao();
