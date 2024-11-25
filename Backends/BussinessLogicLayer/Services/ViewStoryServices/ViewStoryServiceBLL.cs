
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.ViewStoryDtos;
using BussinessLogicLayer.Services.ViewStoryServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.ViewStoryServices
{
     public class ViewStoryServiceBLL : GenericRepositoryBLL<ViewStory, ResultViewStoryDto, ResultViewStoryByIdDto, CreateViewStoryDto, UpdateViewStoryDto, int>, IViewStoryServiceBLL
    {
        public ViewStoryServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}