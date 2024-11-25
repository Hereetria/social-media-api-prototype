

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.PostDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.PostServices
{
    
    public class PostServiceDAL : GenericRepositoryDAL<Post, ResultPostDto, ResultPostByIdDto, CreatePostDto, UpdatePostDto, int>, IPostServiceDAL

    {

        public PostServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}