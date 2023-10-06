using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algebra_of_logic
{
    internal class AOL
    {
        static public bool not(bool A) => !A;                   // 1 Priority
        static public bool and(bool A, bool B)  => A && B;      // 2 Priority
        static public bool or(bool A, bool B)   => A || B;      // 3 Priority
        static public bool xor(bool A, bool B)  => A != B;      // 3 Priority
        static public bool imp(int A, int B)    => A >= B;      // 4 Priority
        static public bool equ(bool A, bool B)  => A == B;      // 5 Priority

    }
}
