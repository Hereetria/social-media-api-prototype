
using DtoLayer.Dtos.PostDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.PostServices
{
    
    public interface IPostServiceDAL : IGenericRepositoryDAL<Post, ResultPostDto, ResultPostByIdDto ,CreatePostDto, UpdatePostDto, int>

    {
        Task<List<ResultPostWithRelationsDto>> GetPostListWithRelationsByUserIdAsync(string userId);
    }
}