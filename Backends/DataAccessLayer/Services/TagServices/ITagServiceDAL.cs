
using DtoLayer.Dtos.TagDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.TagServices
{
    
    public interface ITagServiceDAL : IGenericRepositoryDAL<Tag, ResultTagDto, ResultTagByIdDto ,CreateTagDto, UpdateTagDto, int>

    {

    }
}