
using DtoLayer.Dtos.NotificationDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.NotificationServices
{
    
    public interface INotificationServiceDAL : IGenericRepositoryDAL<Notification, ResultNotificationDto, ResultNotificationByIdDto ,CreateNotificationDto, UpdateNotificationDto, int>

    {
        Task<List<ResultNotificationDto>> GetNotificationListByUserIdAsync(string userId);
    }
}