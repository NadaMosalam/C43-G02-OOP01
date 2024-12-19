using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Helper
{
    [Flags]
    enum WeekDays : byte
    {
        Monday = 1, Tuesday = 2, Wednesday = 4, Thursday = 8, Friday = 16, Saturday = 32, Sunday = 64
    }

    [Flags]
    enum Permissions : byte
    {
        Read = 1, Write = 2, Delete = 4, Execute = 8
    }

    [Flags]
    enum Seas : byte
    {
        Spring = 1, Summer = 2, Autumn = 4, Winter = 8
    }

    [Flags]
    enum Colors
    {
        Red = 1, Green = 2, Blue = 4,
    }

    class TypeA
    {
        public class typeA
        {
            private int X;
            internal int Y;
            public int Z;

        }
    }
}