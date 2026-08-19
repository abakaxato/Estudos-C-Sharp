using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OlaMundo.Classes
{
    internal class ContaBancaria
    {
        private string Nome { get; set; } = string.Empty;
        private double Saldo { get; set; } = 0;
        private int NumeroDaConta { get; set; }

        public ContaBancaria() { }

        private ContaBancaria(int numeroDaConta, string nomeDoTitular, double depositoInicial = 0){
            Nome = nomeDoTitular;
            NumeroDaConta = numeroDaConta;
            Saldo = depositoInicial;
        }



        public ContaBancaria AbrirContaBancaria() {
            int operacao = 0;

            while (operacao != 1)
            {
                try
                {
                    Console.WriteLine("Vamos Abrir a sua conta, Digite o numero da conta :");
                    int numeroDaConta = int.Parse(Console.ReadLine());
                    Console.WriteLine("Numero salvo, agora digite o seu nome :");
                    string nomeDoTitular = Console.ReadLine();
                    Console.WriteLine("Nome salvo, quer adicionar algum valor a sua nova conta ? digite 's' para Sim e 'n' para não");
                    char opcao = char.Parse(Console.ReadLine());


                    if (opcao == 's')
                    {
                        Console.WriteLine("Digite o valor inicial que vai ser inserido na conta");
                        double depositoInicial = double.Parse(Console.ReadLine());

                        ContaBancaria contaCriada = new ContaBancaria(numeroDaConta, nomeDoTitular, depositoInicial)
                        {
                            Nome = nomeDoTitular,
                            Saldo = depositoInicial,
                            NumeroDaConta = numeroDaConta
                        };
                        Console.WriteLine($"Sua Conta foi criada com o ID {contaCriada.NumeroDaConta}, no nome de {contaCriada.Nome} e atualmente tem {contaCriada.Saldo}R$");

                        operacao = 1;

                        return contaCriada;
                    }
                    else if (opcao == 'n')
                    {
                        Console.WriteLine("Ok, vamos tentar criar a sua conta com esses dados...");
                        ContaBancaria contaCriada = new ContaBancaria(numeroDaConta, nomeDoTitular)
                        {
                            Nome = nomeDoTitular,
                            NumeroDaConta = numeroDaConta
                        };
                        
                        Console.WriteLine($"Sua Conta foi criada com o ID {contaCriada.NumeroDaConta}, no nome de {contaCriada.Nome} e atualmente tem {contaCriada.Saldo}R$");
                        
                        operacao = 1;
                        
                        return contaCriada;
                        
                    }
                    else
                    {
                        Console.WriteLine("você digitou algo incorreto vamos tentar novamente...\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("você digitou algo incorreto vamos tentar novamente...\n");
                }
            }
            ContaBancaria conta = new ContaBancaria();
            return conta;
        }

        public ContaBancaria AlterarNomeTitular(ContaBancaria contaBancaria){
            Console.WriteLine($"Digite o novo nome que vai ser utilizado na conta {contaBancaria.NumeroDaConta}");
            string novoNome = Console.ReadLine();
            
            while (novoNome is null) {
                Console.WriteLine("O novo nome não pode ser vazio");
                Console.WriteLine($"Digite o novo nome que vai ser utilizado na conta {contaBancaria.NumeroDaConta}");
                novoNome = Console.ReadLine();
            }
                contaBancaria.Nome = novoNome;
                Console.WriteLine("O nome foi alterado com sucesso");
                Console.WriteLine($"Sua Conta atualmente : ID {contaBancaria.NumeroDaConta}, no nome de {contaBancaria.Nome} e atualmente tem {contaBancaria.Saldo}R$");
            return contaBancaria;
        }

        public ContaBancaria Depositar(ContaBancaria contaBancaria) {
            int operacao = 0;
            Console.WriteLine($"Olá, Quanto você gostaria de depositar na conta {contaBancaria.NumeroDaConta} ?");
            while (operacao != 1)
            {
                try
                {
                    double deposito = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Valor de {deposito}R$ depositado com sucesso");
                        contaBancaria.Saldo += deposito;
                        Console.WriteLine($"Seu Saldo atual é de {contaBancaria.Saldo}R$");
                        operacao = 1;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Você digitou um valor invalido e gerou a sequinte exceção :");
                    Console.WriteLine(e);
                    Console.WriteLine("tente novamente...");
                }
            }

            return contaBancaria;
        }

        public ContaBancaria Sacar(ContaBancaria contaBancaria)
        {
            int operacao = 0;

            if (contaBancaria.Saldo < 5) {
                Console.WriteLine($"Seu Saldo Atual : {contaBancaria.Saldo}R$");
                Console.WriteLine($"Seu saldo atual é menor do que 5.00R$, encerrando operação");
                operacao = 1;
            }
            while (operacao != 1)
            {
                Console.WriteLine($"Quanto você gostaria de sacar da conta {contaBancaria.NumeroDaConta} ?");
                try
                {
                    double saque = double.Parse(Console.ReadLine());

                    if (contaBancaria.Saldo < 5)
                    {
                        Console.WriteLine($"O saldo não pode estar menor do que 5.00R$ para fazer saques o seu saldo atual é de : {contaBancaria.Saldo}");
                        Console.WriteLine("tente novamente...");
                        operacao = 1;
                    } else if (saque > (contaBancaria.Saldo - 5)) {
                        Console.WriteLine($"O saque não pode ser maior do que {saque-5} por causa da taxa de 5.00R$ o saque que você tentou fazer foi de : {saque}");
                        Console.WriteLine($"Saldo na conta : {contaBancaria.Saldo}");
                        Console.WriteLine("tente novamente...\n");
                    }
                    else
                    {
                        Console.WriteLine($"Valor de {saque}R$ sacado com sucesso");
                        contaBancaria.Saldo -= saque;
                        Console.WriteLine("cobrando taxa...");
                        contaBancaria.Saldo -= 5;
                        Console.WriteLine($"Seu Saldo atual é de {contaBancaria.Saldo}");
                        operacao = 1;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Você digitou um valor invalido e gerou a sequinte exceção :");
                    Console.WriteLine(e);
                    Console.WriteLine("tente novamente...");
                }
            }
            return contaBancaria;
        }


    }
}
