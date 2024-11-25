
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.MessageDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.MessageServices
{
        public interface IMessageServiceBLL : IGenericRepositoryBLL<Message, ResultMessageDto, ResultMessageByIdDto, CreateMessageDto, UpdateMessageDto, int>
    {

    }
}