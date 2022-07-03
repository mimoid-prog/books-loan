using System;
namespace zaliczenie
{
    public interface IWriter<T>
    {
        void Write(T obj);
    }
}

