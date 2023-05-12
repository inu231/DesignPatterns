using Visitor.Elements;

namespace Visitor.Visitors
{
    // Visitor
    public interface IVisitor
    {
        void Accept(Carro carro);
    }
}
