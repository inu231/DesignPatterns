using Interpreter.context;

namespace Interpreter.NonTerminal_Expression
{
    public class ExpressaoDia : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            var expressao = context.Expressao;
            context.Expressao = expressao.Replace("DD", context.Data.Day.ToString("00"));
        }
    }
}
