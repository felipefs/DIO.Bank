using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> list_contas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();

            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");

        }

        private static void Sacar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double entradaValorSaque = double.Parse(Console.ReadLine());

            list_contas[indiceConta].Sacar(entradaValorSaque);
        }

        private static void Depositar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double entradaValorDeposito = double.Parse(Console.ReadLine());

            list_contas[indiceConta].Depositar(entradaValorDeposito);
        }

        private static void Transferir()
        {
            Console.Write("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

             Console.Write("Digite o número da conta destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double entradaValorTransf = double.Parse(Console.ReadLine());

            list_contas[indiceContaOrigem].Transferir(entradaValorTransf,list_contas[indiceContaDestino]);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas:");

            if (list_contas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int x = 0; x < list_contas.Count; x++)
            {
                Conta conta = list_contas[x];
                Console.Write("#{0} - ", x);
                Console.WriteLine(conta);
            }


        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta.");

            Console.Write("Digite 1 para conta Pessoa Física ou 2 Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta((TipoConta)entradaTipoConta, entradaSaldo, entradaCredito, entradaNome);

            list_contas.Add(novaConta);

        }

        private static string ObterOpcaoUsuario()
        {

            Console.WriteLine();
            Console.WriteLine("DIO Bank ao seu dispor!");
            Console.WriteLine("Informe a opçao desejada:");

            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;


        }
    }
}
