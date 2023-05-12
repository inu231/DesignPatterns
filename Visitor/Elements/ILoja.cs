using Visitor.Visitors;

namespace Visitor.Elements
{
    public interface ILoja
    {
        public void Visit(IVisitor visitor);
    }
}
