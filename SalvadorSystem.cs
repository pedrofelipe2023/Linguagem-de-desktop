using System.IO.Pipes;

Console.Title = "Salvador System  APP C#";
Console.WriteLine("Olá, Funcionário!");

string Nome;
string Cargo;
Int32 AnoEntrada;
Int32 AnoNascimento;
Int32 AnoAtual;

Console.Write("Digite seu nome completo: ");
Nome = Console.ReadLine();
Console.WriteLine("Seja bem vindo " + Nome);

Console.Write("Informe o seu cargo: ");
Cargo = Console.ReadLine();
Console.WriteLine("Então esse é seu cargo: " + Cargo);

Console.Write("Informe o seu ano de entrada na empresa: ");
AnoEntrada = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o ano atual? ");
AnoAtual = Convert.ToInt32(Console.ReadLine());
Int32 TempoCalculado = AnoAtual - AnoEntrada;

Console.WriteLine("Quantidade de anos que você trabalha na empresa: " + TempoCalculado);
Console.Beep();

Console.Write("digite o ano de nascimento: ");
AnoNascimento = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o ano atual? ");
AnoAtual = Convert.ToInt32(Console.ReadLine());

Int32 IdadeCalculada = AnoAtual - AnoNascimento;

Console.WriteLine("Você tem essa idade: ! " + IdadeCalculada);
Console.Beep();

decimal ValorSalário = 0;

Console.Write("Informe seu Salário: ");
ValorSalário = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informações recebidas com sucesso, Tenha um bom dia de trabalho!!! ");
Console.Beep();