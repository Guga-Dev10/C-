using System;
using System.Globalization;

namespace _8._Conta___Depósito___Exercício {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Conta - Depósito");
            Console.WriteLine();


            CultureInfo CI = CultureInfo.InvariantCulture;        

           
            Console.Write("Entre com o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o número da conta: ");
            int contaregistro = int.Parse(Console.ReadLine());

            Conta c = new Conta();

            Console.Write("Deseja depositar um saldo inicial? (S/N): ");
            char perg = char.Parse(Console.ReadLine());

            double saldo = 0;

            if (perg == 'S') {
                Console.Write("Qual o valor a ser depositado: ");
                saldo = double.Parse(Console.ReadLine(), CI);
                c = new Conta(nome, contaregistro, saldo);
            }
            else if (perg == 'N') {
                Console.WriteLine("Nenhuma valor depositado");
                c = new Conta(nome, contaregistro);
            }

            Console.WriteLine($"Nome = {c.Nome}, Conta {c.ContaRegistro}, " +
                $"Depósito = {c.Saldo.ToString("F2", CI)}" );

            Console.WriteLine();
            Console.Write("Digite a quantia a ser depositada: ");
            double deposito = double.Parse(Console.ReadLine(), CI);

            c.AdicionarSaldo(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Digite a quantia a ser retirada: ");
            double retirada = double.Parse(Console.ReadLine(), CI);

            c.Saque(retirada);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(c);
        }
    }
}
