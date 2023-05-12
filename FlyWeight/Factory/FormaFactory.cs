using FlyWeight.Contract;
using FlyWeight.Model;
using System;
using System.Collections.Generic;

namespace FlyWeight.Factory
{
    public static class FormaFactory
    {
        private static Dictionary<string, IForma> Formas = new Dictionary<string, IForma>();

        /// <summary>
        /// Cria e gerencia os objetos, no caso as formas ( Circulo, etc)
        /// </summary>
        public static IForma GetForm(string key)
        {
            if(Formas.ContainsKey(key))
            {
                return Formas[key];
            }
            else
            {
                if(key == "circulo")
                {
                    var circle = new Circle();
                    return circle;
                }
                else
                {
                    throw new Exception($"Este tipo de objeto {key} não pode ser criado");
                }
            }
        }
    }
}
