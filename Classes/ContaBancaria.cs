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



        public ContaBancaria AbrirContaBancaria(int numeroDaConta, string nomeDoTitular, double depositoInicial = 0) {
            ContaBancaria contaCriada = new ContaBancaria(numeroDaConta, nomeDoTitular, depositoInicial)
            {
                Nome = nomeDoTitular,
                Saldo = depositoInicial,
                NumeroDaConta = numeroDaConta
            };

            Console.WriteLine($"Sua Conta foi criada com o ID {NumeroDaConta}, no nome de {Nome} e atualmente tem {Saldo}R$");
            return contaCriada;
        }

        public ContaBancaria AlterarNomeTitular(ContaBancaria contaBancaria,string novoNome){
            if (novoNome is not null)
            {
                contaBancaria.Nome = novoNome;
            }
            else {
                Console.WriteLine("O novo nome não pode ser vazio");
            }
            return contaBancaria;
        }

        public void Depositar(ContaBancaria contaBancaria) {
            int operacao = 0;
            Console.WriteLine($"Olá, Quanto você gostaria de depositar na conta {contaBancaria.NumeroDaConta} ?");
            while (operacao != 1)
            {
                try
                {
                    double deposito = double.Parse(Console.ReadLine());

                    if (deposito < 5)
                    {
                        Console.WriteLine($"O Deposito não pode ser menor do que 5.00R$ o deposito que você tentou inserir foi de {deposito}");
                        Console.WriteLine("tente novamente...");
                    }
                    else
                    {
                        Console.WriteLine($"Valor de {deposito}R$ depositado com sucesso");
                        contaBancaria.Saldo += deposito;
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
        }

        public void Sacar(ContaBancaria contaBancaria)
        {
            int operacao = 0;

            if (contaBancaria.Saldo < 5) {
                Console.WriteLine($"Seu Saldo Atual : {contaBancaria.Saldo}R$");
                Console.WriteLine($"Seu saldo atual é menor do que 5.00R$, encerrando operação");
                operacao = 1;
            }

            Console.WriteLine($"Quanto você gostaria de sacar da conta {contaBancaria.NumeroDaConta} ?");
            while (operacao != 1)
            {
                try
                {
                    double saque = double.Parse(Console.ReadLine());

                    if (contaBancaria.Saldo < 5)
                    {
                        Console.WriteLine($"O saldo não pode estar menor do que 5.00R$ para fazer saques o seu saldo atual é de : {contaBancaria.Saldo}");
                        Console.WriteLine("tente novamente...");
                        operacao = 1;
                    } else if (saque > (contaBancaria.Saldo - 5)) {
                        Console.WriteLine($"O saque não pode ser maior do que o valor em conta menos a taxa de 5.00R$ o saque que você tentou fazer foi de : {saque}");
                        Console.WriteLine($"Saldo na conta : {contaBancaria.Saldo}");
                        Console.WriteLine("tente novamente...");
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
        }


    }
}
