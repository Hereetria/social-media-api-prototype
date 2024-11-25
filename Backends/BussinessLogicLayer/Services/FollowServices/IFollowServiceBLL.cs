
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.FollowDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.FollowServices
{
        public interface IFollowServiceBLL : IGenericRepositoryBLL<Follow, ResultFollowDto, ResultFollowByIdDto, CreateFollowDto, UpdateFollowDto, int>
    {

    }
}