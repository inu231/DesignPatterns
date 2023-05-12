using System;
using TemplateMethod.Concrete;
using TemplateMethod.TemplateMethods;

namespace TemplateMethod
{
    class Program
    {
        /// <summary>
        /// O factory method é uma especialização do template method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Player MP4 -----------");
            VideoPlayer mp4 = new MP4Player();
            mp4.ExecutarVideo();

            Console.WriteLine("----------- Player MKV -----------");
            VideoPlayer mkv = new MKVPlayer();
            mkv.ExecutarVideo();

            Console.Read();
        }
    }
}
