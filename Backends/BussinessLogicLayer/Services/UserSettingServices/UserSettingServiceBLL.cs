
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.UserSettingDtos;
using BussinessLogicLayer.Services.UserSettingServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.UserSettingServices
{
     public class UserSettingServiceBLL : GenericRepositoryBLL<UserSetting, ResultUserSettingDto, ResultUserSettingByIdDto, CreateUserSettingDto, UpdateUserSettingDto, int>, IUserSettingServiceBLL
    {
        public UserSettingServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}