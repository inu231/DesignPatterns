using Proxy.Proxy;

namespace Proxy
{
    class Program
    {
        /* Proxy é um padrão que fornece um objeto que atua como um substituto para um objeto de serviço real usado por um cliente para controlar o acesso a ele.
         * Permite encapsular a instância de outra classe que possui a mesma interface.
         * Proxy significa 'no lugar de' ou 'em nome de'
         * 
         * Proxy virtual: É um espaço reservado para objetos que consomem muitos recursos para serem criados. Nesste contexto, o objeto real só é criado quando um cliente primeiro solicita ou acessa o objeto.
         * Proxy remoto: Fornece representação local para um objeto que resite em um espaço de endereço diferente. 
         * Proxy de proteção: Controla o acesso a um objeto principal. Aqui o objeto proxy verifica se o chamador tem as pemissões de acesso necessárias antes de encaminhar a solicitação.
         *      -> Usado em procesoss de autenticação
         *
         * Exemplo real de um proxy: Um cheque um ou cartão de crédito é um proxy, pois ele atua no nome da nossa conta bancária para realizar operações financeiras.
         * 
         * Quando deve ser usado:
         * - Quando precisamos criar objetos sob demanda quando suas operações forem solicitadas
         * - Quando temos uma classe com dados sensíveis(que deveriam ser de acesso restrito) e é necessário fornecer o controle de acesso para o objeto original.
         * - Quando temos que usar classes onde a criação dos objetos é muito demorada e consome muitos recursos.
         * - Quando devemos permitir o acesso a um objeto remoto usando um objeto local
         * 
         * Vantagens: 
         *  - Evita a duplicação de objetos grandes e que usam muita memória. Isso aumenta o desempenho da aplicacao atraves do uso de cache para cessar os objetos mais pesados
         *  - O proxy remoto garante a segurança instalando o proxy de codigo local (stub) na maquina do cliente e acessando o servidor com a ajuda do código remoto.
         *  
         *  Desvantagens:
         *  - Esse padrão introduz outra camada de abastração que as vezes pode ser um problema se o código do RealSubject for acessado por alguns dos clientes diretamente e alguns deles puderem acessar as classes Proxy.
         *  - Dependendo do cenário, a implementação pode ser bem complexa
         *  
         * ATENÇÃO: Veja o diagrama de exemplo prático para saber o escopo deste projeto na pasta docs
         */

        static void Main(string[] args)
        {
            var func = new Funcionario("Felipe", "Programador");
            var pastaProxy = new PastaCompartilhadaProxy(func);
            pastaProxy.OperacaoLeituraGravacao();

            func = new Funcionario("Ana", "Programadora");
            pastaProxy = new PastaCompartilhadaProxy(func);
            pastaProxy.OperacaoLeituraGravacao();

            func = new Funcionario("Carol", "CEO");
            pastaProxy = new PastaCompartilhadaProxy(func);
            pastaProxy.OperacaoLeituraGravacao();
        }
    }
}
