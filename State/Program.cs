using State.Context;
using State.States;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ICaixaEletronicoState caixaEletronico = new CaixaEletronico();

            Console.WriteLine();
            caixaEletronico.InserirCartao();
            caixaEletronico.InserirSenha();
            caixaEletronico.SacarDinheiro();
            caixaEletronico.InserirCartao();
            caixaEletronico.EjetarCartao();
            Console.WriteLine();

            Console.WriteLine();
            caixaEletronico.InserirSenha();
            caixaEletronico.SacarDinheiro();
            caixaEletronico.EjetarCartao();
            Console.WriteLine();


            Console.Read();
        }
    }
}
