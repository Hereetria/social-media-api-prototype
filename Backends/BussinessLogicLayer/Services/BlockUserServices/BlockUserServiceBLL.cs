
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.BlockUserDtos;
using BussinessLogicLayer.Services.BlockUserServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.BlockUserServices
{
     public class BlockUserServiceBLL : GenericRepositoryBLL<BlockUser, ResultBlockUserDto, ResultBlockUserByIdDto, CreateBlockUserDto, UpdateBlockUserDto, int>, IBlockUserServiceBLL
    {
        public BlockUserServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}