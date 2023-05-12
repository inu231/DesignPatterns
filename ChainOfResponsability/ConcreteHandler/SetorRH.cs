using ChainOfResponsability.Handler;
using System;

namespace ChainOfResponsability.ConcreteHandler
{
    public class SetorRH : Autorizador
    {
        private readonly int ALCADA_DIAS = 30;

        public override void AutorizarLicenca(string nome, int dias)
        {
            // Caso os dias estejam dentro da alçada de dias deste grupo, a licença será aproada
            if (dias <= ALCADA_DIAS)
            {
                AprovarLicenca(nome, dias);
            }
            // caso contrário, encerrar a cadeia, pois o RH é o ultimo item da cadeia
            else
            {
                Console.WriteLine($"Permissão de licença negada para o funcionário {nome}. Ele não pode tirar {dias} dias de férias.");
            }
        }

        private static void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"Licença aprovada pelo {nameof(SetorRH)} para o funcionário {nome} por {dias} dias");
        }
    }
}
