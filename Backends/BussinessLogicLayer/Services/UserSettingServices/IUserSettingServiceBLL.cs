
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.UserSettingDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.UserSettingServices
{
        public interface IUserSettingServiceBLL : IGenericRepositoryBLL<UserSetting, ResultUserSettingDto, ResultUserSettingByIdDto, CreateUserSettingDto, UpdateUserSettingDto, int>
    {

    }
}