﻿using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Felipe F.");

            Console.WriteLine(minhaConta.ToString());
        }
    }
}
