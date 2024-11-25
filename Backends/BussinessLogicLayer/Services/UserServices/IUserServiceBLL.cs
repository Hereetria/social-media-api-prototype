
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.UserDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.UserServices
{
        public interface IUserServiceBLL : IGenericRepositoryBLL<User, ResultUserDto, ResultUserByIdDto, CreateUserDto, UpdateUserDto, string>
    {

    }
}