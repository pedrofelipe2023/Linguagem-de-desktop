Console.Title = "SmartFit APP C#";
Console.WriteLine("Olá, Bem Vindo ao SmartFit!");

string nome;
string bairro;
string sexo;
Int32 idade;
Int32 AnoNascimento;
Int32 AnoAtual;
Int32 contato;
Int32 massaCorporal;
double ano;
string pagamento;

Console.Write("Digite o ano que você integrou a academia SmartFit: ");
ano = double.Parse(Console.ReadLine());

if (ano <= 2021)
	Console.WriteLine("Seja bem-vindo(a) de volta!");

else if (ano >= 2022)
{
	Console.WriteLine("Seja bem-vindo(a) à nossa academia:");

	Console.Write("Digite seu nome completo: ");
	nome = Console.ReadLine();

	Console.Write("Informe seu Bairro: ");
	bairro = Console.ReadLine();

	Console.Write("Digite o ano de nascimento: ");
	AnoNascimento = Convert.ToInt32(Console.ReadLine());

	Console.Write("Digite o ano atual: ");
	AnoAtual = Convert.ToInt32(Console.ReadLine());

	Int32 IdadeCalculada = AnoAtual - AnoNascimento;
	Console.WriteLine("Você tem essa idade: " + IdadeCalculada);
	Console.Beep();

	Console.Write("Informe sua sexualidade: ");
	sexo = Console.ReadLine();

	Console.Write("Informe seu contato: ");
	contato = Convert.ToInt32(Console.ReadLine());

	Console.Write("Informe sua massa corporal: ");
	massaCorporal = Convert.ToInt32(Console.ReadLine());


	Console.Write("Você já efetuou o pagamento? (Sim/Não): ");
	pagamento = Console.ReadLine().ToLower();

	if (pagamento == "sim")
		Console.WriteLine("Pagamento confirmado. Você está apto(a) a utilizar a academia.");

	else if (pagamento == "não" || pagamento == "nao")
		Console.WriteLine("Pagamento pendente. Por favor, efetue o pagamento para utilizar a academia.");

	else
		Console.WriteLine("Resposta inválida. Por favor, informe 'Sim' ou 'Não'.");
}
else
	Console.WriteLine("O ano inserido não é válido para essa operação.");
