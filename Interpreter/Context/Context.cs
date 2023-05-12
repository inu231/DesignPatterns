using System;

namespace Interpreter.context
{
    public class Context
    {
        public Context(DateTime data)
        {
            Data = data;
        }

        public string Expressao { get; set; }
        public DateTime Data { get; set; }
    }
}
