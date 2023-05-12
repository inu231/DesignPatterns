using ChainOfResponsability.ConcreteHandler;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenteDeProjeto gerenteDeProjeto = new GerenteDeProjeto();
            SupervisorDeEquipe supervisorDeEquipe = new SupervisorDeEquipe();
            SetorRH setorRH = new SetorRH();

            gerenteDeProjeto.ProximoAutorizador(supervisorDeEquipe);
            supervisorDeEquipe.ProximoAutorizador(setorRH);

            gerenteDeProjeto.AutorizarLicenca("Ana", 5);
            gerenteDeProjeto.AutorizarLicenca("Otavio", 10);
            gerenteDeProjeto.AutorizarLicenca("João", 18);
            gerenteDeProjeto.AutorizarLicenca("Natanael", 30);
            gerenteDeProjeto.AutorizarLicenca("kael", 50);
        }
    }
}
