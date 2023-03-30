// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Qual seu nome:");
string nome = Console.ReadLine();

Console.WriteLine($"Qual seu ano de nascimento:");
int ano = int.Parse(Console.ReadLine());

int idade = (DateTime.Now.Year  - ano);
int semana = (ano * 52);

Console.WriteLine($"Sua idade em anos é {idade} e sua idade em semanas é {semana}");

Console.WriteLine($"Obrigado por utilizar o nosso algoritmo");




