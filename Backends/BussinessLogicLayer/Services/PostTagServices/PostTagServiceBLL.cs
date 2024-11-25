
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.PostTagDtos;
using BussinessLogicLayer.Services.PostTagServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.PostTagServices
{
     public class PostTagServiceBLL : GenericRepositoryBLL<PostTag, ResultPostTagDto, ResultPostTagByIdDto, CreatePostTagDto, UpdatePostTagDto, int>, IPostTagServiceBLL
    {
        public PostTagServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}