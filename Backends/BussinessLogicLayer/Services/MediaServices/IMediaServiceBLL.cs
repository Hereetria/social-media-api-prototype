
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.MediaDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.MediaServices
{
        public interface IMediaServiceBLL : IGenericRepositoryBLL<Media, ResultMediaDto, ResultMediaByIdDto, CreateMediaDto, UpdateMediaDto, int>
    {

    }
}