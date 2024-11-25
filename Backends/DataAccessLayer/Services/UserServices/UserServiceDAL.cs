

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.UserDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.UserServices
{
    
    public class UserServiceDAL : GenericRepositoryDAL<User, ResultUserDto, ResultUserByIdDto, CreateUserDto, UpdateUserDto, int>, IUserServiceDAL

    {

        public UserServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}