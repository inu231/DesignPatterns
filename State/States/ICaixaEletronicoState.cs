namespace State.States
{
    public interface ICaixaEletronicoState
    {
        void EjetarCartao();

        void InserirCartao();

        void InserirSenha();

        void SacarDinheiro();

        void GetStatus();
    }
}
