using Facade.Facade;
using Facade.Subsistemas;
using System;

namespace Facade
{
    class Program
    {
        /*
         * Padrão estrural que forneceuma interface unificada para um conjunt de interfaces em um subsistema
         * Define uma interface de nível superior que torna o subsistema mais fácil de usar
         * O Facade fica no topo de um grupo de subsistemas e permie que eles se comuniquem de uma maneira unificada
         * Tem como objetivo esconder a implementação dos objetos, expondo apenas as interfaces para o cliente utilizar
         * Simplifica o uso de processos mais complexos
         * 
         * Quando usar:
         * - Quando queremos simplificar uma sequência de operações complexas
         * - Quando queremos simplificar a interface com o usuário
         * - QUando queremos fornecer uma interface unica e uniforme para as diversas funcionalidades de um subsistema
         * - Quando queremos criar sistemas em camadas. Um Facade provê o ponto de entrada para cada camada do subsistema
         * 
         * Vantagens:
         * - Facilita a portabilidad edo sistema e sua interação com o subsistema 
         * - Isola os clientes dos componentes do subsistema reduzindo o número de objetos com os quais o cliente tem que lidar
         * - Promove um acoplamento fraco entre o subsistema e seus clientes
         *  -> O acoplamento fraco permite varias os componentes do subsistema sem afetar os clientes
         *  
         *  Desvantagens:
         *  - Introduz uma camada adicional entre o cliente e o subsistema, o que contribui para a complexidade do código
         *  - Cria uma dependência entre vários subsistemas, pois vários métodos são chamados a partir deles para servir os clientes
         *  - As APIs específicasd do cliente precisam ser introduzidas na classe Facade, e isso requer manutenção adicional
         * 
         * -> Atenção: Cuidado para não fazer do Facede um objeto Deus (God-Object)
         * 
         * Neste exemplo, faremos uma concessão de crédito. E este processo utiliza vários subsistemas que serão criados 
         * no projeto na pasta subsistemas
         */

        static void Main(string[] args)
        {
            var concessaoCreditoFacade = new ConcessaoCreditoFacade();
            Cliente cliente = new Cliente("André");

            bool podePedirEmprestimo = concessaoCreditoFacade.ConcederEmprestimo(cliente, 20000);

            Console.WriteLine($"Resultado: {podePedirEmprestimo}");
        }
    }
}
