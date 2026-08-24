using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Classes
{
    internal class testes
    {

        public int Triplicar(ref int x) {
            x = x * 3;
            return x;
        }

        public void Triplicar(int x, out int y)
        {
            y = x * 3;
        }
    }
}
