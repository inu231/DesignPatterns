using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public interface IAbstractIterator
    {
        Cliente First();
        Cliente Next();
        bool IsDone { get; }
    }
}
