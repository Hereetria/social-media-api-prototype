
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.CommentDtos;
using BussinessLogicLayer.Services.CommentServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.CommentServices
{
     public class CommentServiceBLL : GenericRepositoryBLL<Comment, ResultCommentDto, ResultCommentByIdDto, CreateCommentDto, UpdateCommentDto, int>, ICommentServiceBLL
    {
        public CommentServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}