using System;
using System.Collections.Generic;
using System.Text;

namespace ConcurrentContainer
{
    public interface IConcurrentStack<T>
    {
        void Push(T value);

        T Pop();

        T Peek();
    }
}
