
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.LikeDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.LikeServices
{
        public interface ILikeServiceBLL : IGenericRepositoryBLL<Like, ResultLikeDto, ResultLikeByIdDto, CreateLikeDto, UpdateLikeDto, int>
    {

    }
}