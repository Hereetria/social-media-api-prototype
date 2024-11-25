

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MediaDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.MediaServices
{
    
    public class MediaServiceDAL : GenericRepositoryDAL<Media, ResultMediaDto, ResultMediaByIdDto, CreateMediaDto, UpdateMediaDto, int>, IMediaServiceDAL

    {

        public MediaServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}