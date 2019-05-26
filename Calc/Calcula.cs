using System;
using System.Collections.Generic;
namespace Calc
{
    class Calcula
    {
        Dictionary<string, Func<int, int, int>> contas = new Dictionary<string, Func<int, int, int>>()
        {
            {"+", (x,y) => x + y },
            {"/",(x,y) => x/y },
            {"-",(x,y) => x-y },
            {"*",(x,y) => x*y }
        };
        public int makeaccoutns(int n1,int n2,string sinal)
        {
            return contas[sinal](n1, n2);
        }
    }
}
