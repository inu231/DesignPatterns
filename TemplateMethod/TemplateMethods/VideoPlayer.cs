using System;

namespace TemplateMethod.TemplateMethods
{
    public abstract class VideoPlayer
    {
        public void ExecutarVideo()
        {
            CarregarVideo();
            DecodificarVideo();
            IniciarVideo();
        }

        public void CarregarVideo()
        {
            Console.WriteLine($"Vídeo Carregando....");
        }

        public abstract void DecodificarVideo();

        public void IniciarVideo()
        {
            Console.WriteLine("Vídeo iniciado!");
        }
    }
}
