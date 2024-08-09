using System;
namespace Arrays
{
	class program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Aula de Arrays!!");

			string[] Cidades = new string[5];
			int[] anoCidades = new int[5];

			Cidades[0] = "Aracaju";
			Cidades[1] = "Fortaleza";
			Cidades[2] = "Maceio";
			Cidades[3] = "Maranhão";
			Cidades[4] = "Noronha";

			anoCidades[0] = 2019;
			anoCidades[1] = 2020;
			anoCidades[2] = 2023;
			anoCidades[3] = 2024;
			anoCidades[4] = 2025;

			Console.WriteLine("Cidades para tirar férias 01: " + Cidades[0]);
			Console.WriteLine("Ano das Viagens 01: " + anoCidades[0]);

			Console.WriteLine("Cidades para tirar férias 02: " + Cidades[1]);
			Console.WriteLine("Ano das Viagens 02: " + anoCidades[1]);

			Console.WriteLine("Cidades para tirar férias 03: " + Cidades[2]);
			Console.WriteLine("Ano das Viagens 03: " + anoCidades[2]);

			Console.WriteLine("Cidades para tirar férias 04: " + Cidades[3]);
			Console.WriteLine("Ano das Viagens 04: " + anoCidades[3]);

			Console.WriteLine("Cidades para tirar férias 05: " + Cidades[4]);
			Console.WriteLine("Ano das Viagens 05: " + anoCidades[4]);
		}
	}
}
