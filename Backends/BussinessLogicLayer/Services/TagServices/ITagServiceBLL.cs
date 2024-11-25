
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.TagDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.TagServices
{
        public interface ITagServiceBLL : IGenericRepositoryBLL<Tag, ResultTagDto, ResultTagByIdDto, CreateTagDto, UpdateTagDto, int>
    {

    }
}