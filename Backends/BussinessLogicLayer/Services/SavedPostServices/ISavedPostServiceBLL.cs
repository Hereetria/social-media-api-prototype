
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.SavedPostDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.SavedPostServices
{
        public interface ISavedPostServiceBLL : IGenericRepositoryBLL<SavedPost, ResultSavedPostDto, ResultSavedPostByIdDto, CreateSavedPostDto, UpdateSavedPostDto, int>
    {

    }
}