using System;

namespace ExercicioSaidaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 50000;
            decimal conta = 10000.8m;
            decimal valorPago;
            String nome, nomeAux;

            Console.WriteLine("O saldo é: {0} ", saldo.ToString("F2"));
            Console.WriteLine("A conta é: {0:00} ", conta.ToString("F2"));

            Console.WriteLine("Informe o valor pago: ");
            valorPago = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("O valor pago é: R$ {0}", valorPago.ToString("F2"));

            Console.WriteLine("Informe o nome: ");
            nome = Console.ReadLine();
            nomeAux = "'" + nome + "'";

            Console.WriteLine("Nome no BD: {0}", nomeAux);
        }
    }
}