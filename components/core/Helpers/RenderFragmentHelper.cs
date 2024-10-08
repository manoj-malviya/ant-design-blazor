﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace AntDesign
{
    public static class RenderFragmentHelper
    {
        public static RenderFragment ToRenderFragment(this string value) => builder => builder.AddContent(1, value);

        public static RenderFragment ForeachLoop<TItem>(this IEnumerable<TItem> items, RenderFragment<TItem> childContent)
        {
            return builder =>
            {
                foreach (var item in items)
                {
                    childContent(item)(builder);
                }
            };
        }
    }
}
