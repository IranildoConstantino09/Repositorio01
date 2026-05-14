// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe seu nome: ");
string Nome = Console.ReadLine();

Console.WriteLine("Informe a sua idade: ");
string idadeTexto = Console.ReadLine();
int idadeConvertida = int.Parse(idadeTexto);

Console.WriteLine("Informe sua altura ");
string alturaTexto = Console.ReadLine();
double alturaConvertida = double.Parse(alturaTexto); 

Console.WriteLine("Você possui CNH? S/N ");
string cnhTexto = Console.ReadLine().ToUpper();
bool cnhConvertida;

Console.WriteLine("Meu nome é: " + Nome);
Console.WriteLine("Minha idade é: " + idadeConvertida);
Console.WriteLine("Minha altura é: " + alturaConvertida);

if (cnhTexto == "S" ){
    cnhConvertida = true;
    Console.WriteLine("Você possui habilitação ");
} 
else {
    cnhConvertida = false;
    Console.WriteLine("Você não possui habilitação ");
}

