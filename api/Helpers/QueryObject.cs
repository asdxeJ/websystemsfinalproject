using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Helpers
{
    public class QueryObject
    {
        // this serves as a filter for get all menu
        public string? Name { get; set; } = null;
        public string? Category { get; set; } = null;
    }
}