
using DtoLayer.Dtos.CommentDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.CommentServices
{
    
    public interface ICommentServiceDAL : IGenericRepositoryDAL<Comment, ResultCommentDto, ResultCommentByIdDto ,CreateCommentDto, UpdateCommentDto, int>

    {
        Task<List<ResultCommentDto>> GetCommentListByPostIdAsync(int postId);
    }
}