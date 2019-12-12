
using System.Globalization;

namespace construtores_propriedades
{
	class Conta
	{
		public string Nome { get;private set; }
		public int NumeroConta { get; set; }
		public double Saldo { get;private set; }

		public Conta() { }

		public Conta(string nome, int numeroConta)
		{
			Nome = nome;
			NumeroConta = numeroConta;
		}

		public Conta(string nome, int numeroConta, double saldo) : this(nome, numeroConta)
		{
			Saldo = saldo;
		}

		public void Deposito(double valor)
		{
			 Saldo += valor;

		}

		public void Saque (double valor)
		{
			 Saldo -= valor + 5;
		}

		public override string ToString()
		{
			return "Conta "
				+ NumeroConta 
				+ ", "
				+ "Titular: "
				+ Nome
				+ ", "
				+ "Saldo : $ " + Saldo.ToString("f2",CultureInfo.InvariantCulture);
		}
	}
}
