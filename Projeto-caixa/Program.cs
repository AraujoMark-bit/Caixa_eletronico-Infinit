using System;
using System.Globalization;

namespace Projeto_caixa {
    class Program {
        static void Main(string[] args) {

            Conta conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Havera deposito inicial? [s/n]? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre com o valor do deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, depositoInicial);
            }
            else {
                conta = new Conta(numero, titular);

            }

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Dados da conta " + conta);

            Console.WriteLine("Entre com o valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("Entre com o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

            Console.Write("Quer continuar? [s/n] ");
            resp = char.Parse(Console.ReadLine());
            while (resp == 's' || resp == 'S') {
                Console.WriteLine("Aguarde! ATUALIZANDO DADOS DA CONTA...");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.Write("Para deposito pressione [1] , Saque [2]  SAIR [3] : ");
                char resp1 = char.Parse(Console.ReadLine());

                if (resp1 == '1') {
                    Console.Write("Entre com valor para depositar novamente: ");
                    quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Deposito(quantia);
                    Console.WriteLine("Dados da conta Atualizados: ");
                    Console.WriteLine(conta);


                }
                else if (resp1 == '2') {
                    Console.Write("Entre com valor para sacar novamente: ");
                    quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Saque(quantia);
                    Console.WriteLine("Dados da conta Atualizados: ");
                    Console.WriteLine(conta);
                }
                else if(resp1 == 'n' || resp1 == '3') {
                    break;
                }
                if (conta.Saldo <= -5 && conta.Saldo >= -10) {
                    Console.WriteLine(">>>>> Você vai se dar mal, controle-se<<<<<");

                }

                if (conta.Saldo <= -10) {
                    Console.WriteLine(">>>>> CUIDADO! O SPC VAI TE CAÇAR !!! <<<<<");

                }


            }


            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine("****************************");
            Console.WriteLine("Dica: Não gaste além do que você ganha. Até LOGO ! ");

        }
    }
}
