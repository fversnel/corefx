// Type: System.Collections.Generic.SortedSet`1
// Assembly: System.Collections, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 8A6D5CC9-3B37-44BA-B857-B4298FA4E7EF
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETPortable\v4.5\Profile\Profile259\System.Collections.dll

using System;
using System.Collections;
using System.Security;

namespace System.Collections.Generic
{
    public class SortedSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, ICollection, IEnumerable
    {
        public IComparer<T> Comparer
        {
            get
            {
                return (IComparer<T>)null;
            }
        }

        public int Count
        {
            get
            {
                return 0;
            }
        }

        public T Max
        {
            get
            {
                return default(T);
            }
        }

        public T Min
        {
            get
            {
                return default(T);
            }
        }

        bool ICollection<T>.IsReadOnly
        {
            get
            {
                return false;
            }
        }

        bool ICollection.IsSynchronized
        {
            get
            {
                return false;
            }
        }

        object ICollection.SyncRoot
        {
            get
            {
                return (object)null;
            }
        }

        public SortedSet()
        {
        }

        public SortedSet(IComparer<T> comparer)
        {
        }

        public SortedSet(IEnumerable<T> collection)
        {
        }

        public SortedSet(IEnumerable<T> collection, IComparer<T> comparer)
        {
        }

        public bool Add(T item)
        {
            return false;
        }

        public virtual void Clear()
        {
        }

        public virtual bool Contains(T item)
        {
            return false;
        }

        public void CopyTo(T[] array)
        {
        }

        public void CopyTo(T[] array, int index)
        {
        }

        public void CopyTo(T[] array, int index, int count)
        {
        }

        public void ExceptWith(IEnumerable<T> other)
        {
        }

        public SortedSet<T>.Enumerator GetEnumerator()
        {
            return new SortedSet<T>.Enumerator();
        }

        public virtual SortedSet<T> GetViewBetween(T lowerValue, T upperValue)
        {
            return (SortedSet<T>)null;
        }

        public virtual void IntersectWith(IEnumerable<T> other)
        {
        }

        [SecuritySafeCritical]
        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            return false;
        }

        [SecuritySafeCritical]
        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            return false;
        }

        [SecuritySafeCritical]
        public bool IsSubsetOf(IEnumerable<T> other)
        {
            return false;
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            return false;
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            return false;
        }

        public bool Remove(T item)
        {
            return false;
        }

        public int RemoveWhere(Predicate<T> match)
        {
            return 0;
        }

        public IEnumerable<T> Reverse()
        {
            return (IEnumerable<T>)null;
        }

        [SecuritySafeCritical]
        public bool SetEquals(IEnumerable<T> other)
        {
            return false;
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
        }

        void ICollection<T>.Add(T item)
        {
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)null;
        }

        void ICollection.CopyTo(Array array, int index)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)null;
        }

        public void UnionWith(IEnumerable<T> other)
        {
        }

        public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
        {
            public T Current
            {
                get
                {
                    return default(T);
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return (object)null;
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return false;
            }

            void IEnumerator.Reset()
            {
            }
        }
    }
}
