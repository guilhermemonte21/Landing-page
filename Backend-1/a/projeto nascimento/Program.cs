// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Algoritmo
// entrada:nome, data , hora
// processamento:ano -> meses -> dias -> horas -> minutos 

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Programa para calcular a idade do cliente");
Console.ResetColor();


Console.WriteLine($"Digite o nome do cliente:");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo ao nosso programa {nome}");

Console.WriteLine($"Digite sua idade:");
int idade = int.Parse(Console.ReadLine());



int exata = (idade * 12);
int dia = (idade * 365);
int horas = (dia * 24);
int minutos = (horas * 60);

Console.WriteLine($"Sua idade em anos é {idade} em meses é {exata} em dias é {dia} em horas é {horas} em minutos é {minutos}");


 
 





