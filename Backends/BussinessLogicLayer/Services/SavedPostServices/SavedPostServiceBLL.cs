
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.SavedPostDtos;
using BussinessLogicLayer.Services.SavedPostServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.SavedPostServices
{
     public class SavedPostServiceBLL : GenericRepositoryBLL<SavedPost, ResultSavedPostDto, ResultSavedPostByIdDto, CreateSavedPostDto, UpdateSavedPostDto, int>, ISavedPostServiceBLL
    {
        public SavedPostServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}