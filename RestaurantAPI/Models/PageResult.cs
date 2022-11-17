using System;
using System.Collections.Generic;

namespace RestaurantAPI.Models
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalPages { get; set; }
        public int ItemsFrom { get; set; }
        public int ItemsTo { get; set; }
        public int TotalItemsCount { get; set; }

        public PagedResult(List<T> items, int totalItemsCount, int pageSize, int PageNumber)
        {
            Items = items;
            TotalItemsCount = totalItemsCount;
            ItemsFrom = pageSize * (PageNumber - 1)+1;
            ItemsTo = ItemsFrom + pageSize - 1;
            TotalPages = (int)Math.Ceiling(totalItemsCount/(double) pageSize);
        }
    }

   
}
