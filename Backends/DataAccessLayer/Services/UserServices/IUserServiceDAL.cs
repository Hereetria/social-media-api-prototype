
using DtoLayer.Dtos.UserDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.UserServices
{
    
    public interface IUserServiceDAL : IGenericRepositoryDAL<User, ResultUserDto, ResultUserByIdDto ,CreateUserDto, UpdateUserDto, int>

    {

    }
}