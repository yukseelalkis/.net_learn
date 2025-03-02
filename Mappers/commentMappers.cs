using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comments;
using api.models;

namespace api.Mappers
{
    public static class commentMappers
    {
        public static CommentDto ToCommentDto(this Comment commentModel){
                return new CommentDto{

                    Id = commentModel.Id,
                    Title = commentModel.Title,
                    Content = commentModel.Content,
                    CreateOn = commentModel.CreateOn,
                    StockId = commentModel.StockId
                };
        }
    }
}