using ChainOfResponsability.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.ConcreteHandler
{
    public class GerenteDeProjeto : Autorizador
    {
        private readonly int ALCADA_DIAS = 5;

        public override void AutorizarLicenca(string nome, int dias)
        {
            // Caso os dias estejam dentro da alçada de dias deste grupo, a licença será aproada
            if(dias <= ALCADA_DIAS)
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
            Console.WriteLine($"Licença aprovada pelo {nameof(GerenteDeProjeto)} para o funcionário {nome} por {dias} dias");
        }
    }
}
