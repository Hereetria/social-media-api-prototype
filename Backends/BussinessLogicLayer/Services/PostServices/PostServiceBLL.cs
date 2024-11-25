
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.PostDtos;
using BussinessLogicLayer.Services.PostServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.PostServices
{
     public class PostServiceBLL : GenericRepositoryBLL<Post, ResultPostDto, ResultPostByIdDto, CreatePostDto, UpdatePostDto, int>, IPostServiceBLL
    {
        public PostServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}