
using DtoLayer.Dtos.MediaDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.MediaServices
{
    
    public interface IMediaServiceDAL : IGenericRepositoryDAL<Media, ResultMediaDto, ResultMediaByIdDto ,CreateMediaDto, UpdateMediaDto, int>

    {

    }
}