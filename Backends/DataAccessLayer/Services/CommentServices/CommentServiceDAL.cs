

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.CommentDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.CommentServices
{
    
    public class CommentServiceDAL : GenericRepositoryDAL<Comment, ResultCommentDto, ResultCommentByIdDto, CreateCommentDto, UpdateCommentDto, int>, ICommentServiceDAL

    {

        public CommentServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}