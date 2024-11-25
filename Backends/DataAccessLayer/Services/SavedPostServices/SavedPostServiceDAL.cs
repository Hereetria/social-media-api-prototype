

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.SavedPostDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.SavedPostServices
{
    
    public class SavedPostServiceDAL : GenericRepositoryDAL<SavedPost, ResultSavedPostDto, ResultSavedPostByIdDto, CreateSavedPostDto, UpdateSavedPostDto, int>, ISavedPostServiceDAL

    {

        public SavedPostServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}