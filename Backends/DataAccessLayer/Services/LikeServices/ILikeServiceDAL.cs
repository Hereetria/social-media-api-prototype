
using DtoLayer.Dtos.LikeDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.LikeServices
{
    
    public interface ILikeServiceDAL : IGenericRepositoryDAL<Like, ResultLikeDto, ResultLikeByIdDto ,CreateLikeDto, UpdateLikeDto, int>

    {

    }
}