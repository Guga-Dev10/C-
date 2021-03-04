using System;

namespace _9._1_Revisao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("conta Bancária");

            Console.WriteLine();
            Console.Write("Digite o número da conta = ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do Titular = ");
            string nome = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Deseja fazer um depósito inicial ? (S/N) ");
            char resp = char.Parse(Console.ReadLine());

            OperacoesBancarias Op = new OperacoesBancarias(); 

            if (resp == 'S' || resp == 's') {
                Console.Write("Valor do depósito = ");
                double deposito = double.Parse(Console.ReadLine());
                Op = new OperacoesBancarias(numero, nome, deposito);
            }
            else if (resp == 'N' || resp == 'n') {
                Console.Write("Sem valor de depósito inicial!");
                Op = new OperacoesBancarias(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados bancários: ");
            Console.WriteLine(Op);
            Console.WriteLine();

            Console.Write("Deseja fazer alguma movimentação financeira? (S/N) ");
            resp = char.Parse(Console.ReadLine());

            Console.WriteLine();

            while (resp == 'S' || resp == 's') {
                if (resp == 'S' || resp == 's') {
                    Console.Write("Deseja Depositar(D) ou Sacar(S) o dinheiro? (D/S) ");
                    char mov = char.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (mov == 'D' || mov == 'd') {
                        Console.Write("Qual o valor do deposito? ");
                        double deposito = double.Parse(Console.ReadLine());
                        Op.Deposito(deposito);
                    }
                    else if (mov == 'S' || mov == 's') {
                        Console.Write("Qual o valor do saque? ");
                        double saque = double.Parse(Console.ReadLine());
                        Op.Saque(saque);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Dados Bancários: ");
                    Console.WriteLine(Op);
                }
                else if (resp == 'N' || resp == 'n') {
                    Console.WriteLine("Nenhum transação financeira selecionada!");
                    Console.WriteLine();
                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine(Op);
                }
                Console.WriteLine();
                Console.Write("Deseja fazer mais alguma transação? (S/N) ");
                resp = char.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Sessão encerrada!");
        }
    }
}
