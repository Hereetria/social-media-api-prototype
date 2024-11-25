
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.PostTagDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.PostTagServices
{
        public interface IPostTagServiceBLL : IGenericRepositoryBLL<PostTag, ResultPostTagDto, ResultPostTagByIdDto, CreatePostTagDto, UpdatePostTagDto, int>
    {

    }
}