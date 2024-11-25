
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.StoryDtos;
using BussinessLogicLayer.Services.StoryServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.StoryServices
{
     public class StoryServiceBLL : GenericRepositoryBLL<Story, ResultStoryDto, ResultStoryByIdDto, CreateStoryDto, UpdateStoryDto, int>, IStoryServiceBLL
    {
        public StoryServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}