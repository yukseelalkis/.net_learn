using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comments;

namespace api.Dtos.Stocks
{
    public class StockDtos
    {
        public int Id { get; set; }

        public string  Symbol { get; set; } = string.Empty;
        public string  CompanyName { get; set; } = string.Empty;      
        public decimal  Purchase { get; set; }

        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long  MarketCap { get; set; }

        // Normalde burada comments olurdu simdi olmicak 
        public List<CommentDto> Comments  { get; set; }
    }
}