
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.NotificationDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.NotificationServices
{
        public interface INotificationServiceBLL : IGenericRepositoryBLL<Notification, ResultNotificationDto, ResultNotificationByIdDto, CreateNotificationDto, UpdateNotificationDto, int>
    {

    }
}