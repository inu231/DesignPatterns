using State.ConcreteState;
using State.States;
using System;

namespace State.Context
{
    public class CaixaEletronico : ICaixaEletronicoState
    {
        private ICaixaEletronicoState _caixaEletronicoState { get; set; }

        public CaixaEletronico()
        {
            _caixaEletronicoState = new CartaoNaoInseridoState();
        }

        public void InserirCartao()
        {
            _caixaEletronicoState.InserirCartao();

            if(_caixaEletronicoState is CartaoNaoInseridoState)
            {   
                _caixaEletronicoState = new CartaoInseridoState();
                Console.WriteLine($"O cartão foi inserido! Mudando o status do cartão para: ");
                GetStatus();
            }
        }

        public void EjetarCartao()
        {
            _caixaEletronicoState.EjetarCartao();

            if(_caixaEletronicoState is CartaoInseridoState)
            {
                _caixaEletronicoState = new CartaoNaoInseridoState();
                Console.WriteLine($"O cartão foi removido! Mudando o status do cartão para: ");
                GetStatus();
            }
        }

        public void InserirSenha()
        {
            _caixaEletronicoState.InserirSenha();
        }

        public void SacarDinheiro()
        {
            _caixaEletronicoState.SacarDinheiro();
        }

        public void GetStatus()
        {
            _caixaEletronicoState.GetStatus();
        }
    }
}
