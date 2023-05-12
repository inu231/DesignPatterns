using Iterator.ConcreteAggregate;
using Iterator.Iterator;

namespace Iterator.ConcreteIterator
{
    public class Iterator : IAbstractIterator
    {
        private int _current = 0;
        private readonly int _step = 1;
        private readonly ConcreteCollection _collection;

        public Iterator(ConcreteCollection collection)
        {
            _collection = collection;
        }

        public bool IsDone { get { return _current >= _collection.Count; } }

        /// <summary>
        /// retorna o primeiro item
        /// </summary>
        /// <returns></returns>
        public Cliente First()
        {
            _current = 0;
            return _collection.GetCliente(_current);
        }

        public Cliente Next()
        {
            _current += _step;

            if(!IsDone)
            {
                return _collection.GetCliente(_current);
            }
            else
            {
                return null;
            }
        }
    }
}
