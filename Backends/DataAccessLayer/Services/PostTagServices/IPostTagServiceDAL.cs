
using DtoLayer.Dtos.PostTagDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using DtoLayer.Dtos.TagDtos;
using DtoLayer.Dtos.PostDtos;

namespace DataAccessLayer.Services.PostTagServices
{
    
    public interface IPostTagServiceDAL : IGenericRepositoryDAL<PostTag, ResultPostTagDto, ResultPostTagByIdDto ,CreatePostTagDto, UpdatePostTagDto, int>

    {
        Task<List<ResultTagDto>> GetTagListByPostIdAsync(int postId);
        Task<List<ResultPostDto>> GetPostListByTagIdAsync(int tagId);
    }
}