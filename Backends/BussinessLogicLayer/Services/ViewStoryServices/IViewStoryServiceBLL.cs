
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.ViewStoryDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.ViewStoryServices
{
        public interface IViewStoryServiceBLL : IGenericRepositoryBLL<ViewStory, ResultViewStoryDto, ResultViewStoryByIdDto, CreateViewStoryDto, UpdateViewStoryDto, int>
    {

    }
}