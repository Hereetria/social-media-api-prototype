
using DtoLayer.Dtos.UserSettingDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.UserSettingServices
{
    
    public interface IUserSettingServiceDAL : IGenericRepositoryDAL<UserSetting, ResultUserSettingDto, ResultUserSettingByIdDto ,CreateUserSettingDto, UpdateUserSettingDto, string>

    {
        Task<ResultUserSettingDto> GetUserSettingByUserIdAsync(string userId);
    }
}