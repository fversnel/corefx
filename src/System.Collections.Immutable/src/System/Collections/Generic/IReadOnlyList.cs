using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

namespace System.Collections.Generic
{
    public interface IReadOnlyList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
    {
        T this[int index] { get; }
    }
}
