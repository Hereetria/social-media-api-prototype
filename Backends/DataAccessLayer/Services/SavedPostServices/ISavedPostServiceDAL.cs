
using DtoLayer.Dtos.SavedPostDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using DtoLayer.Dtos.PostDtos;

namespace DataAccessLayer.Services.SavedPostServices
{
    
    public interface ISavedPostServiceDAL : IGenericRepositoryDAL<SavedPost, ResultSavedPostDto, ResultSavedPostByIdDto ,CreateSavedPostDto, UpdateSavedPostDto, int>

    {
        Task<List<ResultPostDto>> GetSavedPostListByUserIdAsync(string userId);
    }
}