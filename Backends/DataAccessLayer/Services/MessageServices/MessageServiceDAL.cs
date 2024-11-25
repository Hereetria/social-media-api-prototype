

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MessageDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.MessageServices
{
    
    public class MessageServiceDAL : GenericRepositoryDAL<Message, ResultMessageDto, ResultMessageByIdDto, CreateMessageDto, UpdateMessageDto, int>, IMessageServiceDAL

    {

        public MessageServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}