using System;
namespace TDD
{
    public interface ICalculator
    {

        void Set(int x);

        int Peek { get; }

        void Add(int x);

        void Sub(int x);

        void Mul(int x);

        void Div(int x);
    }

}
