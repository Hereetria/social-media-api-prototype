
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.MessageDtos;
using BussinessLogicLayer.Services.MessageServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.MessageServices
{
     public class MessageServiceBLL : GenericRepositoryBLL<Message, ResultMessageDto, ResultMessageByIdDto, CreateMessageDto, UpdateMessageDto, int>, IMessageServiceBLL
    {
        public MessageServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}