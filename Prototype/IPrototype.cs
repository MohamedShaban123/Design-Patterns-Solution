using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal interface IPrototype<T>
    {
        public T ShallowCopy();
        public T DeepCopy();

    }
}
