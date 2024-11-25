
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.LikeDtos;
using BussinessLogicLayer.Services.LikeServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.LikeServices
{
     public class LikeServiceBLL : GenericRepositoryBLL<Like, ResultLikeDto, ResultLikeByIdDto, CreateLikeDto, UpdateLikeDto, int>, ILikeServiceBLL
    {
        public LikeServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}