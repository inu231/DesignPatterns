﻿namespace Proxy
{
    public class Funcionario
    {
        public Funcionario(string nome, string perfil)
        {
            Nome = nome;
            Perfil = perfil;
        }

        public string Nome { get; set; }
        public string Perfil { get; set; }
    }
}
