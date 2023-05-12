using Interpreter.context;

namespace Interpreter
{
    public interface IAbstractExpression
    {
        /// <summary>
        /// O método avaliar é quem vai interpretar o context. E o context é exatamente o que eu quero que seja interpretado
        /// </summary>
        /// <param name="context"></param>
        void Avaliar(Context context);
    }
}
