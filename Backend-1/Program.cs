//variáveis

//declarando uma variável
//tipo nome = valor
// string nome = "Guilherme";
// nome = "Sampaio";
// Console.WriteLine(nome);

// const int idade = 36;
// Console.WriteLine(idade);

// Console.WriteLine($"Text");




//Crie um programa para calcular o IMC de uma pessoa 

//entradas
string nome = "Guilherme";
float peso = 89.9f;
float altura = 1.80f;

//processamento
float imc = peso / (altura * altura);
Console.WriteLine($"O IMC do " + nome + "é de: " + Math.Round(imc,2));
