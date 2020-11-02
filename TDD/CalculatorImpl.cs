using System;
namespace TDD
{
    public class CalculatorImpl : ICalculator
    {
        private int m_Memory;

        //this is a comment

        private bool m_SetCalled;

        public CalculatorImpl()
        {
            m_SetCalled = false;
        }

        public int Peek
        {
            get
            {
                if (!m_SetCalled)
                    throw new Exception();
                return m_Memory;
            }
        }

        public void Add(int x)
        {
            m_Memory += x;
        }

        public void Div(int x)
        {
            if (x == 0)
                throw new Exception();
            m_Memory = m_Memory / x;
        }

        public void Mul(int x)
        {
        }

        public void Set(int x)
        {
            m_SetCalled = true;
            m_Memory = x;
        }

        public void Sub(int x)
        {
        }
    }
}
