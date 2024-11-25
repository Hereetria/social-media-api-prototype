

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.UserSettingDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.UserSettingServices
{
    
    public class UserSettingServiceDAL : GenericRepositoryDAL<UserSetting, ResultUserSettingDto, ResultUserSettingByIdDto, CreateUserSettingDto, UpdateUserSettingDto, string>, IUserSettingServiceDAL

    {

        public UserSettingServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}