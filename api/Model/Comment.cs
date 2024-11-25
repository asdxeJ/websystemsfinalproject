using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        // connects menu through comment
        public int? MenuId { get; set; }
        // navigation property to allow us to navigate within our model
        public Menu? Menu { get; set; }
    }
}