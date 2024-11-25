
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.BlockUserDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.BlockUserServices
{
        public interface IBlockUserServiceBLL : IGenericRepositoryBLL<BlockUser, ResultBlockUserDto, ResultBlockUserByIdDto, CreateBlockUserDto, UpdateBlockUserDto, int>
    {

    }
}