
using DtoLayer.Dtos.StoryDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.StoryServices
{
    
    public interface IStoryServiceDAL : IGenericRepositoryDAL<Story, ResultStoryDto, ResultStoryByIdDto ,CreateStoryDto, UpdateStoryDto, int>

    {
        Task<List<ResultStoryDto>> GetStoryListByUserIdAsync(string userId);
        Task<List<ResultStoryDto>> GetStoryListByFollowingUserIdAsync(string userId);

    }
}