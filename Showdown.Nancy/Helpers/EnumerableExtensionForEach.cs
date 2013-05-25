using System;
using System.Collections.Generic;

namespace Showdown.Nancy.Helpers
    {
    public static class EnumerableExtensionForEach
        {
        public static void ForEach<T>( this IEnumerable<T> list, Action<T> block )
            {
            foreach (var item in list)
                {
                    block( item );
                }
            }
        }
    }