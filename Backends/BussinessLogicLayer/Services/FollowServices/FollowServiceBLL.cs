
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.FollowDtos;
using BussinessLogicLayer.Services.FollowServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.FollowServices
{
     public class FollowServiceBLL : GenericRepositoryBLL<Follow, ResultFollowDto, ResultFollowByIdDto, CreateFollowDto, UpdateFollowDto, int>, IFollowServiceBLL
    {
        public FollowServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}