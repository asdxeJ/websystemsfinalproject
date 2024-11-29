using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Model;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDTO ToCommentDTO(this Comment commendModel)
        {
            return new CommentDTO
            {
                Id = commendModel.Id,
                Title = commendModel.Title,
                Content = commendModel.Content,
                CreatedOn = commendModel.CreatedOn,
                MenuId = commendModel.MenuId
            };
        }
    }
}