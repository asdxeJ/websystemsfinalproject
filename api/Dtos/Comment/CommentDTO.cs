using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        // connects menu through comment
        public int? MenuId { get; set; }
        // navigation property to allow us to navigate within our model
        // public Menu? Menu { get; set; }
        // commented it out because thats going to inject a whole entire object within our comment dto and will look really bad when it returns
    }
}