using System;
using System.Globalization;

namespace _6._Conta_Bancaria {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Banco GPMS investimentos");
            Console.WriteLine();

            OperaçõesBancarias Op = new OperaçõesBancarias(); 

            Console.Write("Digite o nome do cliente = ");
            string nome = Console.ReadLine();
            Console.Write("Qual o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("O cliente irá fazer um depósito inicial (S/N)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'S' || resp == 's') {
                Console.Write("Digite o valor do depósto = ");
                double deposito = double.Parse(Console.ReadLine(), CI);
                Op = new OperaçõesBancarias(nome, conta, deposito);
            } 
            else if (resp == 'N' || resp == 'n') {
                Op = new OperaçõesBancarias(nome, conta);
            }

            Console.WriteLine();
            Console.WriteLine("Nome do ciente = " + Op.Nome);
            Console.WriteLine("Número da conta = " + Op.Conta);
            Console.WriteLine("Saldo = $" + Op.Saldo);

            Console.WriteLine();
            Console.Write("Digite a quantidade a ser depositada = ");
            double deposito2 = double.Parse(Console.ReadLine(), CI);
            Op.Deposito(deposito2);

            Console.WriteLine();
            Console.WriteLine("Nome do ciente = " + Op.Nome);
            Console.WriteLine("Número da conta = " + Op.Conta);
            Console.WriteLine("Saldo = $" + Op.Saldo);

            Console.WriteLine();
            Console.Write("Digite a quantidade a ser sacada = ");
            double saque = double.Parse(Console.ReadLine(), CI);
            Op.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Nome do ciente = " + Op.Nome);
            Console.WriteLine("Número da conta = " + Op.Conta);
            Console.WriteLine("Saldo = $" + Op.Saldo);
        }
    }
}
