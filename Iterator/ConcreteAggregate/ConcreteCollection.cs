using Iterator.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.ConcreteAggregate
{
    public class ConcreteCollection : IAbstractCollection
    {
        private List<Cliente> _clientes = new List<Cliente>();

        public int Count { get { return _clientes.Count; } }

        public ConcreteIterator.Iterator CreateInterator()
        {
            return new ConcreteIterator.Iterator(this);
        }

        public void AddCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public Cliente GetCliente(int index)
        {
            return _clientes[index];
        }
    }
}
