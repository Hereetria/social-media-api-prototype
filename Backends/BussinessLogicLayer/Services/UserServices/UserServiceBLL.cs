
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.UserDtos;
using BussinessLogicLayer.Services.UserServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.UserServices
{
     public class UserServiceBLL : GenericRepositoryBLL<User, ResultUserDto, ResultUserByIdDto, CreateUserDto, UpdateUserDto, string>, IUserServiceBLL
    {
        public UserServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}