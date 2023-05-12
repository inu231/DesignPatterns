using System;
using TemplateMethod.TemplateMethods;

namespace TemplateMethod.Concrete
{
    public class MKVPlayer : VideoPlayer
    {
        public override void DecodificarVideo()
        {
            Console.WriteLine("Decodificando vídeo de MKV!");
        }
    }
}
