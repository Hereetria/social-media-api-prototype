
using DtoLayer.Dtos.BlockUserDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.BlockUserServices
{
    
    public interface IBlockUserServiceDAL : IGenericRepositoryDAL<BlockUser, ResultBlockUserDto, ResultBlockUserByIdDto ,CreateBlockUserDto, UpdateBlockUserDto, int>

    {
         Task<List<ResultBlockUserDto>> GetBlockUserListByUserIdAsync(string userId);
    }
}