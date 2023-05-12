using Interpreter.context;
using Interpreter.NonTerminal_Expression;
using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        
        /*
         * É um padrão que interpreta diferentes gramáticas em diferentes saídas. Não há muito o que se falar sobre
         * este padrão, verificar a pasta DOCS para melhor entendimento.
         * 
         * Neste exemplo, recebemos um formato de data, e convertemos de acordo com o formato que foi passado.
         * 
         */

        static void Main(string[] args)
        {
            List<IAbstractExpression> expressoes = new List<IAbstractExpression>();
            Context context = new Context(DateTime.Now);

            Console.WriteLine($"Data Atual: {context.Data} \n");
            Console.WriteLine($"Digite os formatos YYYY-MM-DD DD-MM-YYY ou MM-DD-YYYY \n");

            context.Expressao = Console.ReadLine().ToUpper();

            var formato = context.Expressao.Split("-");

            foreach (var item in formato)
            {
                if (item == "DD")
                {
                    expressoes.Add(new ExpressaoDia());
                }   
                else if (item == "MM")
                {
                    expressoes.Add(new ExpressaoMes());
                }   
                else if (item == "YYYY")
                {
                    expressoes.Add(new ExpressaoAno());
                }   
            }

            expressoes.Add(new Separador());

            foreach (var expressao in expressoes)
            {
                expressao.Avaliar(context);
            }

            Console.WriteLine($"\n Resultado da interpretação: {context.Expressao}");

        }
    }
}
