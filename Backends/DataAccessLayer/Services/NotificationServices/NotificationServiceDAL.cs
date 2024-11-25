

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.NotificationDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.NotificationServices
{
    
    public class NotificationServiceDAL : GenericRepositoryDAL<Notification, ResultNotificationDto, ResultNotificationByIdDto, CreateNotificationDto, UpdateNotificationDto, int>, INotificationServiceDAL

    {

        public NotificationServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}