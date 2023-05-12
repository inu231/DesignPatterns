using System;

namespace Command.Receiver
{
    /// <summary>
    /// É a classe que executa os comandos de fato
    /// </summary>
    public class Chef
    {
        public void PrepararAlmoco()
        {
            Console.WriteLine("Preparando almoço - Lasanha");
        }

        public void PrepararSobremesa()
        {
            Console.WriteLine("Preparando sobremesa - Petit Gateau");
        }
    }
}
