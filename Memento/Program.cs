using Log.Logging;
using Memento.Mementos;
using Memento.Originator;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            FWLogger.LogInfo("Projeto Memento executado com sucesso!");

            ICalculadora calculadora = new Calculadora();
            calculadora.SetPrimeiroNumero(5);
            calculadora.SetSegundoNumero(10);

            Console.WriteLine($"Resultado da soma: {calculadora.GetCalculoResultado()}");
            Console.WriteLine("Fazendo backup do cálculo");

            // Armazena o backup dos numeros
            ICaretaker memento = calculadora.BackupUltimoCalculo();

            calculadora.SetPrimeiroNumero(15);
            calculadora.SetSegundoNumero(25);

            Console.WriteLine($"Resultado da nova soma: {calculadora.GetCalculoResultado()}");

            // Da um control Z (UNDO) e executa o cálculo anterior novamente!
            calculadora.RestaurarUltimoCalculo(memento);

            Console.WriteLine($"Resultado da soma anterior: {calculadora.GetCalculoResultado()}");

            Console.Read();
        }
    }
}
