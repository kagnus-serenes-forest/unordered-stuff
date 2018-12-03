using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyHelpers
{
    public static class LoopHelper
    {
        public static T times<T>(this T t, Action a)
            where T : IConvertible, new()
        {
            for (int i = 0; i < int.Parse(t.ToString()); ++i)
            {
                a();
            }
            return t;
        }

        public static T times<T>(this T t, Func<IConvertible, T> f)
            where T : IConvertible, new()
        {
            for (int i = 0; i < int.Parse(t.ToString()); ++i)
            {
                f(i);
            }
            return t;
        }
    }
}
