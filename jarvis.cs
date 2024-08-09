// See https://aka.ms/new-console-template for more information

Console.Title = "Jarvis Baiano  APP C#";
Console.WriteLine("Hello, INF07M!");

string Nome;
string Sobrenome;
Int32 Anonascimento;
Int32 AnoAtual;

Console.Write("Digite o seu nome: ");
Nome = Console.ReadLine();

Console.Write("Digite o seu sobrenome: ");
Sobrenome = Console.ReadLine();

Console.WriteLine("Olá como está? " + Nome + " " + Sobrenome);

Console.Write("digite o ano de nascimento: ");
Anonascimento = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o ano atual? ");
AnoAtual = Convert.ToInt32(Console.ReadLine());

Int32 IdadeCalculada = AnoAtual - Anonascimento;

Console.WriteLine("Nossa está com essa idade! " + IdadeCalculada);
Console.Beep();

decimal ValorHora = 0;
decimal HorasTrabalho = 0;
decimal ValorReceber = 0;

Console.Write("Informe seu ValorHora: ");
ValorHora = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe seu HorasTrabalho: ");
HorasTrabalho = Convert.ToInt32(Console.ReadLine());

Console.Write("ValorReceber: ");
ValorReceber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informações recebidas com sucesso!!! ");
Console.Beep();