using System;
namespace zaliczenie
{
    public interface IReader<T>
    {
        T? Read();
    }
}

