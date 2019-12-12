using System;
using System.Globalization;

namespace construtores_propriedades
{
	class Program
	{
		static void Main(string[] args)
		{

			Conta cliente;
			Console.Write("entre com o numero da conta ");
			int numero = int.Parse(Console.ReadLine());
			Console.Write("entre com o titular da conta ");
			string nome = Console.ReadLine();
			Console.Write("haverá depósito inicial (s/n)? ");
			char resp =char.Parse((Console.ReadLine().ToUpper()));
			if (resp =='S')
			{
				Console.WriteLine("entre com o valor do saldo inicial");
				double saldoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

				 cliente = new Conta(nome, numero, saldoInicial);
			}
			else
			{
				 cliente = new Conta(nome, numero);
			}

			Console.WriteLine("dados da conta:");
			Console.WriteLine(cliente);
			Console.WriteLine();

			Console.WriteLine("entre um valor para deposito");
			double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			cliente.Deposito(deposito);
			Console.WriteLine();
			Console.WriteLine("dados da conta atualizados: ");
			Console.WriteLine();
			Console.WriteLine(cliente);

			Console.WriteLine("entre um valor para saque");
			double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			cliente.Saque(saque);
			Console.WriteLine();
			Console.WriteLine("dados da conta atualizados: ");
			Console.WriteLine();
			Console.WriteLine(cliente);


		}
	}
}
