using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invcom_BE.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public Stock? Stock { get; set; }
        public int? StockId { get; set; }
    }
}