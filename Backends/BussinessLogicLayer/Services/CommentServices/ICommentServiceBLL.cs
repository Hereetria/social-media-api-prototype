
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.CommentDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.CommentServices
{
        public interface ICommentServiceBLL : IGenericRepositoryBLL<Comment, ResultCommentDto, ResultCommentByIdDto, CreateCommentDto, UpdateCommentDto, int>
    {

    }
}