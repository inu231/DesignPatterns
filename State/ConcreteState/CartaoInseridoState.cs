using State.States;
using System;

namespace State.ConcreteState
{
    public class CartaoInseridoState : ICaixaEletronicoState
    {
        public void EjetarCartao()
        {
            Console.WriteLine("Cartão ejetado com sucesso!");
        }

        public void GetStatus()
        {
            Console.WriteLine("Cartão Inserido");
        }

        public void InserirCartao()
        {
            Console.WriteLine("Não é possível inserir o cartão neste momento!");
        }

        public void InserirSenha()
        {
            Console.WriteLine("Senha inserida com sucesso!");
        }

        public void SacarDinheiro()
        {
            Console.WriteLine("Sacou o dinheiro!");
        }
    }
}
