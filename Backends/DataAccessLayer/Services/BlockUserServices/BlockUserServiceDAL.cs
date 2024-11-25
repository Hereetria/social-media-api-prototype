

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.BlockUserDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.BlockUserServices
{
    
    public class BlockUserServiceDAL : GenericRepositoryDAL<BlockUser, ResultBlockUserDto, ResultBlockUserByIdDto, CreateBlockUserDto, UpdateBlockUserDto, int>, IBlockUserServiceDAL

    {

        public BlockUserServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}