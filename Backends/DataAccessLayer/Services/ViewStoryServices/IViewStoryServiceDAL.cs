
using DtoLayer.Dtos.ViewStoryDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.ViewStoryServices
{
    
    public interface IViewStoryServiceDAL : IGenericRepositoryDAL<ViewStory, ResultViewStoryDto, ResultViewStoryByIdDto ,CreateViewStoryDto, UpdateViewStoryDto, int>
    {
        Task<List<ResultViewStoryDto>> GetViewStoryListByStoryIdAsync(int storyId);
    }
}