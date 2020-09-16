﻿using System.Collections.Generic;
using System.Linq;

namespace Expenses.Queries.Test.Helpers
{
    public static class EFHelpers
    {
        public static IQueryable<T> ToEFQuery<T>(this IEnumerable<T> source)
        {
            return new TestAsyncEnumerable<T>(source);
        }
    }
}
