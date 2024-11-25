
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.MediaDtos;
using BussinessLogicLayer.Services.MediaServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.MediaServices
{
     public class MediaServiceBLL : GenericRepositoryBLL<Media, ResultMediaDto, ResultMediaByIdDto, CreateMediaDto, UpdateMediaDto, int>, IMediaServiceBLL
    {
        public MediaServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}