// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Validation;
/*
namespace System.Collections.Immutable
{
    public partial struct ImmutableArray<T>
    {
        /// <summary>
        /// An array enumerator.
        /// </summary>
        /// <remarks>
        /// It is important that this enumerator does NOT implement IDisposable.
        /// We want the iterator to inline when we do foreach and to not result in
        /// a try/finally frame in the client.
        /// </remarks>
        public struct Enumerator
        {
            /// <summary> 
            /// The array being enumerated.
            /// </summary>
            private readonly T[] array;

            /// <summary>
            /// The currently enumerated position.
            /// </summary>
            /// <value>
            /// -1 before the first call to <see cref="MoveNext"/>.
            /// >= this.array.Length after MoveNext returns false.
            /// </value>
            private int index;

            /// <summary>
            /// Initializes a new instance of the <see cref="Enumerator"/> struct.
            /// </summary>
            /// <param name="array">The array to enumerate.</param>
            internal Enumerator(T[] array)
            {
                this.array = array;
                this.index = -1;
            }

            /// <summary>
            /// Gets the currently enumerated value.
            /// </summary>
            public T Current
            {
                get
                {
                    // PERF: no need to do a range check, we already did in MoveNext.
                    // if user did not call MoveNext or ignored its result (incorrect use)
                    // he will still get an exception from the array access range check.
                    return this.array[this.index];
                }
            }

            /// <summary>
            /// Advances to the next value to be enumerated.
            /// </summary>
            /// <returns><c>true</c> if another item exists in the array; <c>false</c> otherwise.</returns>
            public bool MoveNext()
            {
                return ++this.index < this.array.Length;
            }
        }

        /// <summary>
        /// An array enumerator that implements IEnumerator pattern (including IDisposable).
        /// </summary>
        private class EnumeratorObject : IEnumerator<T>
        {
            /// <summary>
            /// A shareable singleton for enumerating empty arrays.
            /// </summary>
            private static readonly IEnumerator<T> EmptyEnumerator =
                new EnumeratorObject(ImmutableArray<T>.Empty.array);

            /// <summary>
            /// The array being enumerated.
            /// </summary>
            private readonly T[] array;

            /// <summary>
            /// The currently enumerated position.
            /// </summary>
            /// <value>
            /// -1 before the first call to <see cref="MoveNext"/>.
            /// this.array.Length - 1 after MoveNext returns false.
            /// </value>
            private int index;

            /// <summary>
            /// Initializes a new instance of the <see cref="Enumerator"/> class.
            /// </summary>
            private EnumeratorObject(T[] array)
            {
                this.index = -1;
                this.array = array;
            }

            /// <summary>
            /// Gets the currently enumerated value.
            /// </summary>
            public T Current
            {
                get
                {
                    // this.index >= 0 && this.index < this.array.Length
                    // unsigned compare performs the range check above in one compare
                    if ((uint)this.index < (uint)this.array.Length)
                    {
                        return this.array[this.index];
                    }

                    // Before first or after last MoveNext.
                    throw new InvalidOperationException();
                }
            }

            /// <summary>
            /// Gets the currently enumerated value.
            /// </summary>
            object IEnumerator.Current
            {
                get { return this.Current; }
            }

            /// <summary>
            /// If another item exists in the array, advances to the next value to be enumerated.
            /// </summary>
            /// <returns><c>true</c> if another item exists in the array; <c>false</c> otherwise.</returns>
            public bool MoveNext()
            {
                int newIndex = this.index + 1;
                int length = array.Length;

                // unsigned math is used to prevent false positive if index + 1 overflows.
                if ((uint)newIndex <= (uint)length)
                {
                    this.index = newIndex;
                    return (uint)newIndex < (uint)length;
                }

                return false;
            }

            /// <summary>
            /// Resets enumeration to the start of the array.
            /// </summary>
            void IEnumerator.Reset()
            {
                this.index = -1;
            }

            /// <summary>
            /// Disposes this enumerator.
            /// </summary>
            /// <remarks>
            /// Currently has no action.
            /// </remarks>
            public void Dispose()
            {
                // we do not have any native or disposable resources.
                // nothing to do here.
            }

            /// <summary>
            /// Creates an enumerator for the specified array.
            /// </summary>
            internal static IEnumerator<T> Create(T[] array)
            {
                if (array.Length != 0)
                {
                    return new EnumeratorObject(array);
                }
                else
                {
                    return EmptyEnumerator;
                }
            }
        }
    }
}
*/