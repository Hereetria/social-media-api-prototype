
using DtoLayer.Dtos.MessageDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.MessageServices
{
    
    public interface IMessageServiceDAL : IGenericRepositoryDAL<Message, ResultMessageDto, ResultMessageByIdDto ,CreateMessageDto, UpdateMessageDto, int>

    {
        Task<List<ResultMessageDto>> GetSendedMessageListByReceiverUserIdAsync(string userId);
        Task<List<ResultMessageDto>> GetReceivedMessageListBySenderUserIdAsync(string userId);


    }
}