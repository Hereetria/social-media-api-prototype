

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.PostTagDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.PostTagServices
{
    
    public class PostTagServiceDAL : GenericRepositoryDAL<PostTag, ResultPostTagDto, ResultPostTagByIdDto, CreatePostTagDto, UpdatePostTagDto, int>, IPostTagServiceDAL

    {

        public PostTagServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}