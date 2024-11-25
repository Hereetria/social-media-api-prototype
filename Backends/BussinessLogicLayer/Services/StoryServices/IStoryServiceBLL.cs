
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.StoryDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.StoryServices
{
        public interface IStoryServiceBLL : IGenericRepositoryBLL<Story, ResultStoryDto, ResultStoryByIdDto, CreateStoryDto, UpdateStoryDto, int>
    {

    }
}