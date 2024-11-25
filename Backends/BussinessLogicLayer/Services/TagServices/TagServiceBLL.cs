
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.TagDtos;
using BussinessLogicLayer.Services.TagServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.TagServices
{
     public class TagServiceBLL : GenericRepositoryBLL<Tag, ResultTagDto, ResultTagByIdDto, CreateTagDto, UpdateTagDto, int>, ITagServiceBLL
    {
        public TagServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}