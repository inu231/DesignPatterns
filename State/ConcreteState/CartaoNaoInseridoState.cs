using State.States;
using System;

namespace State.ConcreteState
{
    public class CartaoNaoInseridoState : ICaixaEletronicoState
    {
        public void EjetarCartao()
        {
            Console.WriteLine("Não há nenhum cartão inserido que possa ser ejetado!");
        }

        public void GetStatus()
        {
            Console.WriteLine("Cartão Não Inserido");
        }

        public void InserirCartao()
        {
            Console.WriteLine("Cartão inserido com s ucesso!");
        }

        public void InserirSenha()
        {
            Console.WriteLine("Não é possível inseir senha neste momento!");
        }

        public void SacarDinheiro()
        {
            Console.WriteLine("Não é possível sacar o dinheiro neste momento!");
        }
    }
}
