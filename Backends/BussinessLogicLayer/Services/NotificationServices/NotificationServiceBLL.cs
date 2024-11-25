
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.NotificationDtos;
using BussinessLogicLayer.Services.NotificationServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.NotificationServices
{
     public class NotificationServiceBLL : GenericRepositoryBLL<Notification, ResultNotificationDto, ResultNotificationByIdDto, CreateNotificationDto, UpdateNotificationDto, int>, INotificationServiceBLL
    {
        public NotificationServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}