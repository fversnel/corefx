using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Collections.Immutable
{
    public static class StringUtils
    {
        public static string Join<T>(this IEnumerable<T> collection, string separator) {
            if (collection == null) {
                return null;
            }
            var formattedString = "";
            var isFirst = true;
            foreach (var elem in collection) {
                if (!isFirst) {
                    formattedString += separator;
                }
                isFirst = false;

                formattedString += elem;
            }
            return formattedString;
        }
    }
}
