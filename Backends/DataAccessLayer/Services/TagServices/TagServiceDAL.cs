

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.TagDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.TagServices
{
    
    public class TagServiceDAL : GenericRepositoryDAL<Tag, ResultTagDto, ResultTagByIdDto, CreateTagDto, UpdateTagDto, int>, ITagServiceDAL

    {

        public TagServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}