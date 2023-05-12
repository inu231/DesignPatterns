using System;
using TemplateMethod.TemplateMethods;

namespace TemplateMethod.Concrete
{
    public class MP4Player : VideoPlayer
    {
        public override void DecodificarVideo()
        {
            Console.WriteLine("Decodificando vídeo de mp4!");
        }
    }
}
