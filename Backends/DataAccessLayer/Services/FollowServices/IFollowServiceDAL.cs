
using DtoLayer.Dtos.FollowDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using DtoLayer.Dtos.UserDtos;

namespace DataAccessLayer.Services.FollowServices
{
    
    public interface IFollowServiceDAL : IGenericRepositoryDAL<Follow, ResultFollowDto, ResultFollowByIdDto ,CreateFollowDto, UpdateFollowDto, int>

    {
        Task<List<ResultUserDto>> GetFollowerUserListByFollowingUserIdAsync(string userId);
        Task<List<ResultUserDto>> GetFollowingUserListByFollowerUserIdAsync(string userId);


    }
}