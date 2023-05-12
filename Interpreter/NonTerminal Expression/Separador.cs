using Interpreter.context;

namespace Interpreter.NonTerminal_Expression
{
    public class Separador : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            var expression = context.Expressao;
            context.Expressao = expression.Replace(" ", "-");
        }
    }
}
