using ChainOfResponsability.Handler;
using System;

namespace ChainOfResponsability.ConcreteHandler
{
    class SupervisorDeEquipe : Autorizador
    {
        private readonly int ALCADA_DIAS = 15;

        public override void AutorizarLicenca(string nome, int dias)
        {
            // Caso os dias estejam dentro da alçada de dias deste grupo, a licença será aproada
            if (dias <= ALCADA_DIAS)
            {
                AprovarLicenca(nome, dias);
            }
            // caso contrário, passar para o próximo autorizador, ou seja, o proximo item da cadeia
            else
            {
                _autorizador?.AutorizarLicenca(nome, dias);
            }
        }

        private static void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"Licença aprovada pelo {nameof(SupervisorDeEquipe)} para o funcionário {nome} por {dias} dias");
        }
    }
}
