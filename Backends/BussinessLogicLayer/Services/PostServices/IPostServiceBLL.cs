
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.PostDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.PostServices
{
        public interface IPostServiceBLL : IGenericRepositoryBLL<Post, ResultPostDto, ResultPostByIdDto, CreatePostDto, UpdatePostDto, int>
    {

    }
}